using GMPress.Delivery.Interfaces;
using GMPress.Administration.Data.Entities;
using GMPress.Administration.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Desktop.Interfaces
{
    interface IPageHubContext:
        IAdministrationContext,
        IDeliveryContext
    {
        User CurrentUser { get; }
        void ShowAuthorize();
    }

}
