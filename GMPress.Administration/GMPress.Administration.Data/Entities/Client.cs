using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace GMPress.Administration.Data.Entities
{
    public class Client : User
    {
        public long ClientID { get; set; } = 0;

        public JObject ContactInfos { get; set; }
        
    }
}
