using App.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App.Services
{
    public class NavigationService : ContentPage
    {
        public NavigationService()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello Page" }
                }
            };
        }

        public async void Navigate(string PageName)
        {
            App.Master.IsPresented = false;
            switch (PageName)
            {
                
                case "NewOrderPage":
                    await Navigate(new NewOrderPage()); //Volvemos al MainPage
                    break;
                
                case "SettingsPage":
                    await App.Navigator.PopToRootAsync(); //Volvemos al MainPage
                    break;
                case "MainPage":
                    await App.Navigator.PopToRootAsync(); //Volvemos al MainPage
                    break;
                default:
                    break;
            }
        }

        private static async Task Navigate<T>(T page) where T: Page  //
        {
            NavigationPage.SetHasBackButton(page, false);
            NavigationPage.SetBackButtonTitle(page, "Atrás"); //iOS
            await App.Navigator.PushAsync(page);
        }

      

        internal void SetMainPage(string pageName)
        {
            switch (pageName)
            {
                case "MainPage":
                    App.Current.MainPage = new MainPage();
                    break;
                default:
                    break;
            }
        }
    }
}
