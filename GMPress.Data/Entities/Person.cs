using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public abstract class Person
    {
        public long PersonID { get; set; } = 0;
        public Person(string personName)
        {
            this.personName = new PersonNameDC(personName);
        }
        private PersonNameDC personName { get; }

        public string FullName => personName.FullName;
        public override string ToString() => personName.ToString();
    }
}
