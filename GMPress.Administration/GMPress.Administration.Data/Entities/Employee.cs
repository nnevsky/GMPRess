using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Administration.Data.Entities
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee : User
    {
        public int EmployeeID { get; set; }
    }
}
