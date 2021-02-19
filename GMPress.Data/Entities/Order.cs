using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public class Order
    {
        public long OrderID { get; set; } = 0;
        public long OrderNumber { get; set; }
        public Customer Customer { get; set; }
        public ContactPerson ContactPerson { get; set; }
    }
}
