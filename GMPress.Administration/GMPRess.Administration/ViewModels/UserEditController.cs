using GMPress.Administration.Data.Entities;

namespace GMPress.Administration.ViewModels
{
    internal class UserEditController
    {
        public User User;
        public UserEditController(User user)
        {
            User = user;
        }

        public string Title => User.FullName;
    }
}
