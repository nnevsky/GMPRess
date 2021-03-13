using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    /// <summary>
    /// Абстрактный класс перосны человека, который может быть клиентом, менеджером, сотрудником, контактным лицом
    /// </summary>
    
    public class Person
    {
        public int PersonID { get; set; } = 0;
        public virtual string FullName
        {
            get => _fullName ?? string.Empty;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new FormatException($"Недопустимое значение FullName в классе Person: '{value}'");
                else
                {
                    string[] str = value.Trim().Split(' ');
                    try
                    {
                        FirstName = $"{str[0].Substring(0, 1).ToUpper()}{(str[0].Length>0 ? str[0].Substring(1, str[0].Length - 1).ToLower() : string.Empty)}";
                        StringBuilder sb = new StringBuilder(FirstName);
                        if (str.Length > 1)
                        {
                            LastName = $"{str[1].Substring(0, 1).ToUpper()}{(str[1].Length>0 ? str[1].Substring(1, str[1].Length - 1).ToLower() : string.Empty)}";
                            sb.Append($" {str[1].Substring(0, 1).ToUpper()}.");
                        }
                        if (str.Length > 2)
                        {
                            Patronimic = $"{str[2].Substring(0, 1).ToUpper()}{(str[2].Length>0 ? str[2].Substring(1, str[2].Length - 1).ToLower() : string.Empty)}";
                            sb.Append($"{str[2].Substring(0, 1).ToUpper()}.");
                        }
                        _shortName = sb.ToString();
                    }
                    catch { throw new FormatException($"Недопустимое преобразование имени '{value}' в классе Person"); }
                    _fullName = $"{FirstName} {LastName} {Patronimic}";
                }
            }
        }
        public string ShortName
        {
            get
            {
                if (string.IsNullOrEmpty(_shortName))
                {
                    if ((_firstName.Length + _lastName.Length + _patronimic.Length) > 0)
                    {
                        FullName = $"{_firstName} {_lastName} {_patronimic}";
                    }
                    else
                        _shortName = "<<< Без имени >>>";
                }
                return _shortName;
            }
        }

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value ?? string.Empty;
            }
        }
        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value ?? string.Empty;
            }
        }
        public string Patronimic
        {
            get => _patronimic;
            set
            {
                _patronimic = value ?? string.Empty;
            }
        }

        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private string _patronimic = string.Empty;

        private string _fullName = string.Empty;
        private string _shortName = string.Empty;

        public override string ToString() => ShortName ?? string.Empty;
    }
}