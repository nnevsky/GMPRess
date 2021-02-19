using System;
using System.Collections.Generic;
using System.Text;

namespace GMPress.Administration.Data.Entities
{
    public class Client : User
    {
        public long ClientID { get; set; } = 0;

        public string EMail { get; set; }
        
        public Client(string clientName, string clientPassword)
            : base(clientName, clientPassword)
        {
        }
    }
}
