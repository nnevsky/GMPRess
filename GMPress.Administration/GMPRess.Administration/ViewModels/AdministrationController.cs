using GMPress.Administration.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Administration.ViewModels
{
    public class AdministrationController
    {
        readonly IAdministrationContext context;
        public AdministrationController(IAdministrationContext context)
        {
            this.context = context;
        }
    }
}
