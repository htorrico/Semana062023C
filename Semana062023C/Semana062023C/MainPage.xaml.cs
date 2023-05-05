using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana062023C
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            List<string> names = new List<string>();
            names.Add("Hugo");
            names.Add("Paco");
            names.Add("Luis");
            names.Add("Juan");

            lvNames.ItemsSource = names;




        }
    }
}
