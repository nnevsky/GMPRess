using GMPress.Delivery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Delivery.ViewModels
{
    public class DeliveryController
    {
        readonly IDeliveryContext context;
        public DeliveryController(IDeliveryContext context)
        {
            this.context = context;
        }
    }
}
