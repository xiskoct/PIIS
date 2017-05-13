using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace App.Models
{ //Campos que necesitemos serializar
    
    public class Order : ContentPage
    {
        [JsonProperty("id")] //Se realiza si no coincide los campos

    }
}
