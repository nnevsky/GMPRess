using GMPress.Administration.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Authorize.Interfaces
{
    public interface IAuthorizeContext
    {
        void AssignUser(User currentUser);
    }
}
