using System;
using System.Collections.Generic;
using System.Text;

namespace GMPress.Administration.Data.Entities
{
    public class Manager : Client
    {
        public long ManagerID { get; set; } = 0;
        public Manager(string managerName, string managerPassword)
            : base(managerName, managerPassword)
        {

        }
    }
}
