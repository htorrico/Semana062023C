using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana062023C
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            


        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Person> people= new List<Person>();

            people.Add(new Person { Name = "Hugo", LastName = "Torrico",DNI="1111111" });
            people.Add(new Person { Name = "Juan", LastName = "Torrico", DNI = "222222" });
            people.Add(new Person { Name = "Janeth", LastName = "Marquez", DNI = "22222" });
            people.Add(new Person { Name = "Yury", LastName = "Marquez", DNI = "333333" });


            this.lvPeople.ItemsSource = people;
        }
    }
}