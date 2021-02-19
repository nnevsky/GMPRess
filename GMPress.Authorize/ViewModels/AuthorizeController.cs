using GMPress.Administration.Data.Entities;
using GMPress.Authorize.Interfaces;
using GMPress.Data.Cmd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMPress.Authorize.ViewModels
{
    public class AuthorizeController
    {
        // public Bitmap logo => Properties.Resources.logo;

        public List<Manager> UserItems => new List<Manager>(
            new[]
            {
                new Manager("невский николай георгиевич", ""),
                new Manager("Клоков Андрей", ""),
                new Manager("Кокорев Александр", ""),
                new Manager("Федюшина Дарья", "")
            });
        public User SelectedUser { get; set; }

        readonly IAuthorizeContext authorizeContext;
        public AuthorizeController(IAuthorizeContext authorizeContext)
        {
            this.authorizeContext = authorizeContext;
        }

        public RelayCommand SetAuthorizeCmd => new RelayCommand(o => authorizeContext.AssignUser(SelectedUser));
    }
}
