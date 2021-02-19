using GMPress.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GMPress.Administration.Data.Entities
{
    public abstract class User : Person
    {
        public long UserID { get; set; } = 0;

        private static HashAlgorithm algorithm = SHA256.Create();
        private static Encoding Encoding = Encoding.Default; //Encoding.GetEncoding(1251);

      
        public User(string userName, string password) : base(userName)
        {
            PasswordHash = GetHash(HashSource(userName, password));
        }
        public User(string userName, byte[] passwordHash) : base(userName)
        {
            PasswordHash = passwordHash;
        }

        public bool IsValidUserPassword()
        {
            return true;
        }
        private static string HashSource(string userName, string password)
        {
            var sb = new StringBuilder();
            foreach (var item in userName.Split(' '))
            {
                sb.Append(item.ToUpper());
            }
            sb.Append(password);

            return sb.ToString();
        }
        public byte[] PasswordHash { get; set; } = new byte[0];
        public IEnumerable<Group> Groups { get; set; } = new List<Group>();

        private static byte[] GetHash(string input) => algorithm.ComputeHash(Encoding.GetBytes(input));
           
        private static bool VerifyHash(string input, string hash)
        {
            var verifyHash = GetHash(input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hash, verifyHash) == 0;
        }
    }
}
