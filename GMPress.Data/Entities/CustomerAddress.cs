using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public class CustomerAddress
    {
        public Customer Customer { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
