using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App.Pages
{
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing() //En el momento que la pagina aparezca llevamos la clase App a 
        {
            base.OnAppearing();
            App.Navigator = this.Navigator;  //Referencia al NavigationPage de nuestro MasterPage 
        }
    }
}
