using System;
using System.Security.Cryptography;

namespace InvoicesChecker.Services;

public class DropboxContentHasher : HashAlgorithm
{
    private readonly SHA256 _overallHasher;
    private readonly SHA256 _blockHasher;
    private int _blockPos = 0;

    public const int BlockSize = 4 * 1024 * 1024;

    public DropboxContentHasher() : this(SHA256.Create(), SHA256.Create(), 0) { }

    public DropboxContentHasher(SHA256 overallHasher, SHA256 blockHasher, int blockPos)
    {
        this._overallHasher = overallHasher;
        this._blockHasher = blockHasher;
        this._blockPos = blockPos;
    }

    public override int HashSize { get { return _overallHasher.HashSize; } }

    protected override void HashCore(byte[] input, int offset, int len)
    {
        int inputEnd = offset + len;
        while (offset < inputEnd)
        {
            if (_blockPos == BlockSize)
            {
                FinishBlock();
            }

            int spaceInBlock = BlockSize - this._blockPos;
            int inputPartEnd = Math.Min(inputEnd, offset + spaceInBlock);
            int inputPartLength = inputPartEnd - offset;
            _blockHasher.TransformBlock(input, offset, inputPartLength, input, offset);

            _blockPos += inputPartLength;
            offset += inputPartLength;
        }
    }

    protected override byte[] HashFinal()
    {
        if (_blockPos > 0)
        {
            FinishBlock();
        }
        _overallHasher.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
        return _overallHasher.Hash;
    }

    public override void Initialize()
    {
        _blockHasher.Initialize();
        _overallHasher.Initialize();
        _blockPos = 0;
    }

    private void FinishBlock()
    {
        _blockHasher.TransformFinalBlock(Array.Empty<byte>(), 0, 0);
        byte[] blockHash = _blockHasher.Hash;
        _blockHasher.Initialize();

        _overallHasher.TransformBlock(blockHash, 0, blockHash.Length, blockHash, 0);
        _blockPos = 0;
    }

    private const string HEX_DIGITS = "0123456789abcdef";

    /// <summary>
    /// A convenience method to convert a byte array into a hexadecimal string.
    /// </summary>
    public static string ToHex(byte[] data)
    {
        var r = new System.Text.StringBuilder();
        foreach (byte b in data)
        {
            r.Append(HEX_DIGITS[(b >> 4)]);
            r.Append(HEX_DIGITS[(b & 0xF)]);
        }
        return r.ToString();
    }
}