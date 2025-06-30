using System.Security.Cryptography;
using System.Text;

namespace ISKI.Core.Security.Authenticator.EmailAuthenticator;

public static class EmailAuthenticatorHelper
{
    // Aktivasyon anahtarı oluşturur
    public static string GenerateActivationKey()
    {
        var key = Guid.NewGuid().ToString("N"); // 32 karakterlik random key
        return key;
    }

    // Aktivasyon anahtarını hash'ler (isteğe bağlı ek güvenlik için)
    public static string HashActivationKey(string activationKey)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(activationKey);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    // Aktivasyon anahtarını doğrular
    public static bool VerifyActivationKey(string plainKey, string hashedKey)
    {
        var hashOfInput = HashActivationKey(plainKey);
        return hashOfInput == hashedKey;
    }
}
