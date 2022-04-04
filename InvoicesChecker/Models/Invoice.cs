using System.Collections.Generic;
using System.Security.Policy;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore;

namespace InvoicesChecker.Models;

[XmlRoot(ElementName = "FACTUURREGEL")]
public class FACTUURREGEL
{
    public int Id { get; set; }
    [XmlElement(ElementName = "EAN_ARTIKELCODE")]
    public string EAN_ARTIKELCODE { get; set; }
    [XmlElement(ElementName = "GELEVERD_AANTAL")]
    public string GELEVERD_AANTAL { get; set; }
    [XmlElement(ElementName = "FACTUUR_AANTAL")]
    public string FACTUUR_AANTAL { get; set; }
    [XmlElement(ElementName = "PRIJS")]
    public decimal PRIJS { get; set; }
    [XmlElement(ElementName = "BTWSOORT")]
    public string BTWSOORT { get; set; }
    [XmlElement(ElementName = "PRIJSEENHEID")]
    public string PRIJSEENHEID { get; set; }
    [XmlElement(ElementName = "NETTOBEDRAG")]
    public decimal NETTOBEDRAG { get; set; }
    [XmlElement(ElementName = "ARTIKELCODE_LEVERANCIER")]
    public string ARTIKELCODE_LEVERANCIER { get; set; }
    [XmlElement(ElementName = "ARTIKELOMSCHRIJVING")]
    public string ARTIKELOMSCHRIJVING { get; set; }
}

[XmlRoot(ElementName = "FACTUURREGELS")]
public class FACTUURREGELS
{
    public int Id { get; set; }
    [XmlElement(ElementName = "FACTUURREGEL")]
    public List<FACTUURREGEL> FACTUURREGEL { get; set; }
}

[Index(nameof(ORDERNR_AFNEMER), IsUnique = true)]
[XmlRoot(ElementName = "FACTUUR")]
public class FACTUUR
{
    public int Id { get; set; }
    [XmlElement(ElementName = "GLN_PARTNER")]
    public string GLN_PARTNER { get; set; }
    [XmlElement(ElementName = "GLN_ENVELOP_ZELF")]
    public string GLN_ENVELOP_ZELF { get; set; }
    [XmlElement(ElementName = "TESTINDICATOR")]
    public string TESTINDICATOR { get; set; }
    [XmlElement(ElementName = "FACTUURSOORT")]
    public string FACTUURSOORT { get; set; }
    [XmlElement(ElementName = "FACTUURNUMMER")]
    public string FACTUURNUMMER { get; set; }
    [XmlElement(ElementName = "FACTUURDATUM")]
    public string FACTUURDATUM { get; set; }
    [XmlElement(ElementName = "ORDERNR_AFNEMER")]
    public string ORDERNR_AFNEMER { get; set; }
    [XmlElement(ElementName = "ORDER_DATUM")]
    public string ORDER_DATUM { get; set; }
    [XmlElement(ElementName = "PAKBONNUMMER")]
    public string PAKBONNUMMER { get; set; }
    [XmlElement(ElementName = "AFLEVERDATUM")]
    public string AFLEVERDATUM { get; set; }
    [XmlElement(ElementName = "FACTUURREFERENTIENR")]
    public string FACTUURREFERENTIENR { get; set; }
    [XmlElement(ElementName = "GLN_KOPERADRES")]
    public string GLN_KOPERADRES { get; set; }
    [XmlElement(ElementName = "GLN_AFLEVERADRES")]
    public string GLN_AFLEVERADRES { get; set; }
    [XmlElement(ElementName = "GLN_LEVERANCIER")]
    public string GLN_LEVERANCIER { get; set; }
    [XmlElement(ElementName = "GLN_FACTUURADRES")]
    public string GLN_FACTUURADRES { get; set; }
    [XmlElement(ElementName = "BTW_REGISTRATIE_NR")]
    public string BTW_REGISTRATIE_NR { get; set; }
    [XmlElement(ElementName = "VALUTA")]
    public string VALUTA { get; set; }
    [XmlElement(ElementName = "FACTUURREGELS")]
    public FACTUURREGELS FACTUURREGELS { get; set; }

    public decimal Total { get; set; }
    public decimal Payed { get; set; }
    public int? PaymentId { get; set; }
    public Payment Payment { get; set; }
}

[XmlRoot(ElementName = "ROZIS")]
public class InvoiceFile
{
    public int Id { get; set; }
    [XmlElement(ElementName = "FACTUUR")]
    public List<FACTUUR> FACTUUR { get; set; }
    public string Client { get; set; }
    public int Year { get; set; }
    public int Week { get; set; }
    public string RawXml { get; set; }

}