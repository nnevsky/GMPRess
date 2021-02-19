using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public class ContactPerson : Person
    {
        public string Description { get; set; } = string.Empty;
        public ContactPerson(string contactName, string description) : base(contactName)
        {
            Description = description;
        }
    }
}
