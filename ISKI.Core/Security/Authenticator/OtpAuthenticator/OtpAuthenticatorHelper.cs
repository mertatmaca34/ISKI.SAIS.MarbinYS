using OtpNet;

namespace ISKI.Core.Security.Authenticator.OtpAuthenticator;

public static class OtpAuthenticatorHelper
{
    // Kullanıcıya özel Secret Key üretir
    public static byte[] GenerateSecretKey()
    {
        var secret = KeyGeneration.GenerateRandomKey(20); // 160 bit
        return secret;
    }

    // Kullanıcının SecretKey'inden QR Kod stringi oluşturabiliriz (isteğe bağlı)
    public static string GenerateOtpProvisionUrl(string email, byte[] secretKey, string issuer = "ISKI.SARS")
    {
        var base32Secret = Base32Encoding.ToString(secretKey);
        return $"otpauth://totp/{issuer}:{email}?secret={base32Secret}&issuer={issuer}";
    }

    // Kullanıcının gönderdiği OTP'yi doğrular
    public static bool VerifyCode(byte[] secretKey, string code)
    {
        var totp = new Totp(secretKey);
        return totp.VerifyTotp(code, out long timeWindowUsed, new VerificationWindow(previous: 1, future: 1));
    }
}
