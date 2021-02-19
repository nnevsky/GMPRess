using GMPress.Administration.Data.Entities;
using GMPress.Desktop.Interfaces;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;

namespace GMPress.Desktop.ViewModels
{
    internal class MainController : DependencyObject, ICommonContext, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public User CurrentUser { get; set; }
        public MainController()
        {
            ShowAuthorize();
        }

        public string Title => $"{Assembly.GetEntryAssembly().FullName}: {Assembly.GetEntryAssembly().ImageRuntimeVersion}";
        public Page CurrentPage { get; set; }

        private void ShowPage(Page page)
        {
            CurrentPage = page;

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentPage)));
        }

        public void AssignUser(User currentUser)
        {
            if (currentUser != null)
            {
                CurrentUser = currentUser;
                ShowPage(new Views.Pages.PageHub
                {
                    DataContext = new PageHubController(this)
                });
            }
        }

        public void ShowAuthorize()
        {
            ShowPage(new Authorize.Views.Pages.AuthorizePage
            {
                DataContext = new Authorize.ViewModels.AuthorizeController(this)
            });
        }
    }
}
