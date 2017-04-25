using App.Pages;
using App.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.ViewModels
{
    public class MainViewModel
    {
        NavigationService navigationService; //Navegacion del main
        public MainViewModel()
        {
            navigationService = new NavigationService();
            LoadMenu();
            LoadData();
        }



        #region Properties
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        public ObservableCollection<OrderViewModel> Orders { get; set; }

        #endregion

        #region Commands
        public ICommand GoToCommand
        {
            get { return new RelayCommand<string>(GoTo); }
        }

        private void GoTo(string pageName)
        {
            navigationService.Navigate(pageName);
        }

        #endregion

        public ICommand StartCommand
        {
            get { return new RelayCommand(Start); }
        }

        private void Start()
        {
           
            navigationService.SetMainPage("MasterPage");

        }




        #region Methods

        private void LoadMenu()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_orders",
                Title = "Pedidos",
                PageName = "MainPage"
            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_clients",
                Title = "Clientes",
                PageName = "ClientsPage"
            });
            Menu.Add(new MenuItemViewModel()
            {
                Icon = "ic_action_alarm",
                Title = "Alarmas",
                PageName = "AlarmsPage"
            });
        }
        private void LoadData()
        {
            Orders = new ObservableCollection<OrderViewModel>();
            for (int i = 0; i < 5; i++)
            {
                Orders.Add(new OrderViewModel()
                {
                    Title = "asd",
                    DeliveryDate = DateTime.Today,
                    Description = "asdfvasfasf"
                });

            }
        }

        #endregion

    

    }
}  

        
      
        
    

