using System.Security.Cryptography;
using System.Text;

namespace Payments.Cardlink
{
    public static class DigestHelper
    {
        public static string GenerateDigest(string data, string secret)
        {
            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
            return System.Convert.ToBase64String(hash);
        }
    }
}
