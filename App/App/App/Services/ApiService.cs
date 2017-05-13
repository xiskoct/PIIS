using App.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Xamarin.Forms;

namespace App.Services
{
    public class ApiService : ContentPage
    {
        public ApiService()
        {
            public async Task<List<Order>> GetAllOrders()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "";
                client.DefaultRequestHeaders.Add("");
                var result = await client.GetAsync(url);

                string data = await result.Content.ReadAsStringAsync();

                if (result.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<List<Order>>(data);
                }
                else
                    return new List<Order>();
            }
        }
        }
    }
}
