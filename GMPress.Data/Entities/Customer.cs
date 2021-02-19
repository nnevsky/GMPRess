using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public class Customer
    {
        public long CustomerID { get; set; } = 0;
        public string INN { get; set; }
        public Address Address { get; set; }
        public List<ContactPerson> ContactList { get; set; } = new List<ContactPerson>();
        public Customer()
        {

        }
    }
}
