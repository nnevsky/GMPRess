using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GMPress.Data.Entities;

namespace GMPress.Administration.Data.Entities
{
    /// <summary>
    /// Группа прав доступа
    /// </summary>
    public class Group
    {
        public Guid GroupID { get; set; }

        public string GroupName { get; set; }
        public IEnumerable<Rule> Rules { get; set; }

        public override string ToString() => GroupName;
    }
}
