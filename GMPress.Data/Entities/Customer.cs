using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace GMPress.Data.Entities
{
    public class Customer : Person
    {
        public int CustomerId { get; set; }

        public List<string> Phones { get; set; } = new List<string>();
        public List<string> EMails { get; set; } = new List<string>();
    }
}
