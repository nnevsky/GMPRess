using GMPress.Authorize.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Desktop.Interfaces
{
    internal interface ICommonContext :
        IAuthorizeContext,
        IPageHubContext
    {
    }

}
