using App.Pages;
using App.Services;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App.ViewModels
{
    public class MenuItemViewModel
    {
        NavigationService navigationService; //Navegacion del Menu Lateral


        public MenuItemViewModel()
        {
            navigationService = new NavigationService();
        }


        public string Icon { get; set; }
        public string Title { get; set; }
        public string PageName { get; set; }


    public ICommand NavigateCommand
    {
        get { return new RelayCommand(() => navigationService.Navigate(PageName)); }
    }

}

}
