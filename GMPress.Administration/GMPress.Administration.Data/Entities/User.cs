using GMPress.Data.Entities;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace GMPress.Administration.Data.Entities
{
    /// <summary>
    /// Пользователь программы
    /// </summary>
    public class User : Person
    {
        public int UserID { get; set; } = 0;

        private static HashAlgorithm algorithm = SHA256.Create();
        private static Encoding Encoding = Encoding.Default; //Encoding.GetEncoding(1251);

        public string UserName => FullName;

        public IReadOnlyCollection<Group> Groups { get; set; } = new List<Group>();

        public byte[] Hash { get; set; }

        private string _password = string.Empty;
        public string Password
        {
            set
            {
                _password = value ?? string.Empty;

                MakeHash();
            }
        }

        public override string FullName 
        { 
            get => base.FullName;
            set
            {
                base.FullName = value ?? string.Empty;

                MakeHash();
            }
        }

        private void MakeHash()
        {
            if (!string.IsNullOrEmpty(FullName) && !string.IsNullOrEmpty(_password))
            {
                var sb = new StringBuilder();
                foreach (var item in FullName.Split(' '))
                {
                    sb.Append(item.ToUpper());
                }
                sb.Append(_password);

                Hash = GetHash(sb.ToString());
            }
        }
        private byte[] GetHash(string source) => algorithm.ComputeHash(Encoding.GetBytes(source));

        public override string ToString() => UserName;
    }
}
