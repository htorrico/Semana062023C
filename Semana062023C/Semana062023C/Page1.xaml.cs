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

            people.Add(new Person { Name = "Hugo", LastName = "Torrico" });
            people.Add(new Person { Name = "Juan", LastName = "Torrico" });
            people.Add(new Person { Name = "Janeth", LastName = "Marquez" });
            people.Add(new Person { Name = "Yury", LastName = "Marquez" });


            this.lvPeople.ItemsSource = people;
        }
    }
}