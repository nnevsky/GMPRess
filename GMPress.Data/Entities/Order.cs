﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Data.Entities
{
    public abstract class Order
    {
        public int OrderId { get; set; }
        public int OrderNum { get; set; }
        public string OrderName { get; set; }

        public double Summ { get; set; }

        public Customer Customer { get; set; }
    }
}
