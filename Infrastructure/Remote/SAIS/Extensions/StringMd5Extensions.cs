using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Remote.SAIS.Extensions;

public static class StringMd5Extensions
{
    /// <summary>
    /// String'i UTF-8 olarak MD5'ler ve 32 karakterlik hex string döner.
    /// </summary>
    public static string ToMd5Hex(this string input, bool upperCase = false)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));

        byte[] data = Encoding.UTF8.GetBytes(input);
        byte[] hash = MD5.HashData(data);

        var sb = new StringBuilder(32);
        string fmt = upperCase ? "X2" : "x2";
        foreach (byte b in hash)
            sb.Append(b.ToString(fmt));

        return sb.ToString();
    }

    public static string DoubleMD5(this string input, bool upperCase = false)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));

        byte[] data = Encoding.UTF8.GetBytes(input);
        byte[] hash = MD5.HashData(data);

        var sb = new StringBuilder(32);
        string fmt = upperCase ? "X2" : "x2";
        foreach (byte b in hash)
            sb.Append(b.ToString(fmt));

        return sb.ToString().ToMd5Hex();
    }

    /// <summary>
    /// String'in MD5 hash'ini raw byte[] olarak döner.
    /// </summary>
    public static byte[] ToMd5Bytes(this string input)
    {
        if (input is null) throw new ArgumentNullException(nameof(input));
        return MD5.HashData(Encoding.UTF8.GetBytes(input));
    }

    /// <summary>
    /// String'in MD5'i beklenen hex ile eşleşiyor mu?
    /// </summary>
    public static bool Md5Equals(this string input, string expectedHex, bool caseInsensitive = true)
    {
        if (expectedHex is null) throw new ArgumentNullException(nameof(expectedHex));
        var actual = input.ToMd5Hex();
        return caseInsensitive
            ? actual.Equals(expectedHex, StringComparison.OrdinalIgnoreCase)
            : actual.Equals(expectedHex, StringComparison.Ordinal);
    }
}
