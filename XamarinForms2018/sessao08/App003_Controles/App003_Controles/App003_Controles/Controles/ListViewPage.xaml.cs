using App003_Controles.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App003_Controles.Controles
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            BuildListViewCars();

        }
        private List<Car> LoadListViewData()
        {
            List<Car> itemsList = new List<Car>();
            itemsList.Add(new Car { Brand = "Subaru", Rate = "A+" });
            itemsList.Add(new Car { Brand = "Honda", Rate = "A+" });
            itemsList.Add(new Car { Brand = "Toyota", Rate = "A++" });
            itemsList.Add(new Car { Brand = "Fiat", Rate = "B" });
            itemsList.Add(new Car { Brand = "RAM", Rate = "C" });
            itemsList.Add(new Car { Brand = "Dodge", Rate = "C" });
            itemsList.Add(new Car { Brand = "Lexus", Rate = "A++" });
            itemsList.Add(new Car { Brand = "Mazda", Rate = "A+" });

            return itemsList;
        }

        private void BuildListViewCars()
        {
            List<Car> myData = LoadListViewData();
            lvCars.ItemsSource = myData;
        }

    }
}