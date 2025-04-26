using System.Security.Cryptography;

namespace Fitness_Tracker.Utils
{
    public static class PasswordHasher
    {
        private const int SaltSize = 16; 
        private const int KeySize = 32;
        private const int Iterations = 10000;
        private static readonly HashAlgorithmName _hashAlgorithmName = HashAlgorithmName.SHA256;

        public static string HashPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);

            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                _hashAlgorithmName,
                KeySize);

            string saltString = Convert.ToBase64String(salt);
            string hashString = Convert.ToBase64String(hash);
            return $"{saltString}.{hashString}";
        }

        public static bool VerifyPassword(string password, string hashedPassword)
        {
            string[] parts = hashedPassword.Split('.');
            if (parts.Length != 2)
            {
                return false; 
            }

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedHash = Convert.FromBase64String(parts[1]);

            byte[] computedHash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iterations,
                _hashAlgorithmName,
                KeySize);
            
            return CryptographicOperations.FixedTimeEquals(computedHash, storedHash);
        }
    }
}
