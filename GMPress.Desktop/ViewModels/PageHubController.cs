using GMPress.Data.Cmd;
using GMPress.Desktop.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GMPress.Desktop.ViewModels
{
    class PageHubController
    {
        internal class TabExt
        {
            public string Header { get; set; }
            public Page TabPage { get; set; }
        }
        readonly IPageHubContext context;
        public ObservableCollection<TabExt> TabItems { get; set; } = new ObservableCollection<TabExt>();
        public string CurrentUser => $"Пользователь: {context.CurrentUser}";
        public PageHubController(IPageHubContext context)
        {
            this.context = context;

            ShowAdministration();
            ShowDelivery();
        }

        public void ShowAdministration()
        {
            ShowTab("Администрирование", new Administration.Views.AdministrationPage { DataContext = new Administration.ViewModels.AdministrationController(context) });
        }

        public void ShowDelivery()
        {
            ShowTab("Доставка", new Delivery.Views.Pages.DeliveryPage { DataContext = new Delivery.ViewModels.DeliveryController(context) });
        }
        private void ShowTab(string header, Page page)
        {
            TabItems.Add(new TabExt { Header = header, TabPage = page });
        }

        public ICommand LogoutCmd => new RelayCommand(o => context.ShowAuthorize());
        public ICommand ExitCmd => new RelayCommand(o => Application.Current.Shutdown());

    }
}
