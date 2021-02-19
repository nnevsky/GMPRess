using System;
using System.Text;

namespace GMPress.Data.Entities
{
    public class PersonNameDC : DisplayConverter
    {
        public string FullName { get; }
        public string FirstName { get; } = string.Empty;
        public string LastName { get; } = string.Empty;
        public string PatronimicName { get; } = string.Empty;

        private string shortName;

        public PersonNameDC(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
                throw new FormatException("Недопустимое имя в классе FullNameDC");
            else
            {
                FullName = fullName.Trim();
                string[] str = FullName.Split(' ');
                if (str.Length > 0)
                {
                    try
                    {
                        FirstName = $"{str[0].Substring(0, 1).ToUpper()}{str[0].Substring(1, str[0].Length - 1).ToLower()}";
                        StringBuilder sb = new StringBuilder(FirstName);
                        if (str.Length > 1)
                        {
                            LastName = $"{str[1].Substring(0, 1).ToUpper()}{str[1].Substring(1, str[1].Length - 1).ToLower()}";
                            sb.Append($" {str[1].Substring(0, 1).ToUpper()}.");
                        }
                        if (str.Length > 2)
                        {
                            PatronimicName = $"{str[2].Substring(0, 1).ToUpper()}{str[2].Substring(1, str[2].Length - 1).ToLower()}";
                            sb.Append($"{str[2].Substring(0, 1).ToUpper()}.");
                        }
                        shortName = sb.ToString();
                    }
                    catch { throw new FormatException($"Недопустимое преобразование имени '{fullName}' в классе FullNameDC" ); }
                    FullName = $"{FirstName} {LastName} {PatronimicName}";
                }
            }
        }

        public override string ToString() => shortName;
    }
}
