using System.Security.Cryptography;
using System.Text;

namespace ISKI.Core.Security.Hashing;

public static class HashingHelper
{
    public static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
    {
        using var hmac = new HMACSHA512(); // HMACSHA512 kullanıyoruz, SHA256 da olabilirdi.
        passwordSalt = hmac.Key; // Rastgele üretilen salt
        passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
    }

    public static bool VerifyPasswordHash(string password, byte[] storedHash, byte[] storedSalt)
    {
        using var hmac = new HMACSHA512(storedSalt);
        var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        return computedHash.SequenceEqual(storedHash);
    }
    public static string DoubleMD5Hash(string input)
    {
        for (int i = 0; i < 2; i++)
        {
            byte[] data = MD5.HashData(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new();
            for (int j = 0; j < data.Length; j++)
            {
                sBuilder.Append(data[j].ToString("x2"));
            }

            input = sBuilder.ToString();
        }

        return input;
    }
}
