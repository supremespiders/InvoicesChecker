using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using InvoicesChecker.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Extensions;

public static class SqlExtensions
{
    public static async Task BulkInsert<T>(this MyContext dbContext, List<T> models, int batch = 1000) where T : class
    {
        if (models.Count == 0) return;
        var table = dbContext.Model.FindEntityType(typeof(T))?.GetSchemaQualifiedTableName();
        var fieldsSql = new StringBuilder($"insert into {table} (");
        var properties = new List<PropertyInfo>();
        var connectionString = dbContext.Database.GetConnectionString();
        foreach (var propertyInfo in typeof(T).GetProperties())
        {
            if (propertyInfo.Name.Equals("Id")) continue;
            if (propertyInfo.GetCustomAttributes(typeof(NotMappedAttribute), true).Any()) continue;
            var t = propertyInfo.PropertyType;
            if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                if (t.GetGenericArguments()[0] != typeof(int))
                    continue;
            }
            else if (Type.GetTypeCode(t) == TypeCode.Object)
            {
                continue;
            }
            properties.Add(propertyInfo);
            fieldsSql.Append($"[{propertyInfo.Name}]").Append(",");
        }
        fieldsSql.Remove(fieldsSql.Length - 1, 1);
        fieldsSql.Append(") values");

        var sql = new StringBuilder(fieldsSql.ToString());
        var inserted = 0;
        for (var i = 0; i < models.Count; i++)
        {
            var model = models[i];

            sql.Append("\n(");
            foreach (var propertyInfo in properties)
            {
                var val = propertyInfo.GetValue(model)?.ToString() ?? "null";

                if (propertyInfo.PropertyType == typeof(decimal))
                {

                    sql.Append(((decimal)propertyInfo.GetValue(model)).ToString(CultureInfo.InvariantCulture)).Append(",");
                }else if (propertyInfo.PropertyType == typeof(bool))
                {
                    sql.Append((bool)propertyInfo.GetValue(model) ? "1" : "0").Append(",");
                }
                else if (propertyInfo.PropertyType == typeof(double))
                {

                    sql.Append(((double)propertyInfo.GetValue(model)).ToString(CultureInfo.InvariantCulture)).Append(",");
                }
                else if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    sql.Append($"'{((DateTime)propertyInfo.GetValue(model)):yyyy-MM-dd H:mm:ss}',");
                }
                else if (propertyInfo.PropertyType == typeof(string))
                {
                    sql.Append(propertyInfo.GetValue(model)?.ToString() == null ? "null," : $"'{val.Replace("'", "''")}',");
                }
                else if (propertyInfo.PropertyType.IsEnum)
                {
                    sql.Append((int)propertyInfo.GetValue(model, null)).Append(",");
                }
                else
                {
                    sql.Append(val.Replace("'", "''")).Append(",");
                }
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append("),");
            inserted++;
            if ((inserted % batch == 0) || i == models.Count - 1)
            {
                sql.Remove(sql.Length - 1, 1);
                sql.Append(";");
                Debug.WriteLine(sql);
                Debug.WriteLine(connectionString);

                await using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    await using (var cmd = new SqlCommand(sql.ToString(), connection))
                    {
                        var x = await cmd.ExecuteNonQueryAsync();
                        Console.WriteLine($"insert {x}");
                    }
                }

                sql = new StringBuilder(fieldsSql.ToString());
                inserted = 0;
            }
        }
    }


    public static async Task BulkUpdate<T>(this MyContext dbContext, List<T> models, List<string> propertiesToCheck, int batch = 1000) where T : class
    {
        if (models.Count == 0) return;
        var table = dbContext.Model.FindEntityType(typeof(T))?.GetSchemaQualifiedTableName();
        var properties = typeof(T).GetProperties().Where(x => propertiesToCheck.Contains(x.Name));
        var propertyId = typeof(T).GetProperty("Id");
        var sql = new StringBuilder("");
        int inserted = 0;
        var connectionString = dbContext.Database.GetConnectionString();
        for (var i = 0; i < models.Count; i++)
        {
            var model = models[i];

            sql.Append($"update {table} set ");
            foreach (var propertyInfo in properties)
            {
                sql.Append($"[{propertyInfo.Name}]").Append(" = ");
                string val = propertyInfo.GetValue(model)?.ToString() ?? "null";
                if (propertyInfo.PropertyType == typeof(decimal))
                {

                    sql.Append(((decimal)propertyInfo.GetValue(model)).ToString(CultureInfo.InvariantCulture)).Append(",");
                }
                else if (propertyInfo.PropertyType == typeof(bool))
                {
                    sql.Append((bool)propertyInfo.GetValue(model) ? "1" : "0").Append(",");
                }
                else if (propertyInfo.PropertyType == typeof(double))
                {

                    sql.Append(((double)propertyInfo.GetValue(model)).ToString(CultureInfo.InvariantCulture)).Append(",");
                }
                else if (propertyInfo.PropertyType == typeof(DateTime))
                {
                    sql.Append($"'{((DateTime)propertyInfo.GetValue(model)):yyyy-MM-dd H:mm:ss}',");
                }
                else if (propertyInfo.PropertyType == typeof(string))
                {
                    sql.Append(propertyInfo.GetValue(model)?.ToString() == null ? "null," : $"'{val.Replace("'", "''")}',");
                }
                else if (propertyInfo.PropertyType.IsEnum)
                {
                    sql.Append((int)propertyInfo.GetValue(model, null)).Append(",");
                }
                else
                {
                    sql.Append(val.Replace("'", "''")).Append(",");
                }
            }
            sql.Remove(sql.Length - 1, 1);
            sql.Append($" where Id={propertyId.GetValue(model)};\n");

            inserted++;
            if ((inserted % batch == 0) || i == models.Count - 1)
            {
                Console.WriteLine(sql);
                await using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();
                    await using (var cmd = new SqlCommand(sql.ToString(), connection))
                    {
                        var x = await cmd.ExecuteNonQueryAsync();
                        Console.WriteLine($"insert {x}");
                    }
                }

                sql = new StringBuilder();
                inserted = 0;
            }
        }
    }
}