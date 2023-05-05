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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            
            List<Student> students = new List<Student>();
            students.Add(new Student { FullName = "Hugo Torrico", Grade = 20 });
            students.Add(new Student { FullName = "Juan Perez", Grade = 10 });
            students.Add(new Student { FullName = "Miguel Arce", Grade = 15 });
            students.Add(new Student { FullName = "Yury Marquez", Grade = 12 });

            foreach (var item in students)
            {
                item.Color = Color.Red;
                if (item.Grade > 14)
                    item.Color = Color.Blue;

            }
            lvStudents.ItemsSource = students;



        }
    }
}