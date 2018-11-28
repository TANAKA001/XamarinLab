using App_Cels.Controller;
using App_Cels.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Cels.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage ()
		{
			InitializeComponent ();
          
            ListPersons.ItemsSource = PersonController.ListPerson();
            ListShores.ItemsSource = ShoresController.ListShore();
        }

        private void ListShores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Shore _shore = (Shore)e.SelectedItem;
            Navigation.PushAsync(new DetailShore(_shore));
        }

        private void MenuItem_ClickedVacation(object sender, EventArgs e)
        {
            MenuItem _btn = (MenuItem)sender;
            Person _person = (Person)_btn.CommandParameter;

            DisplayAlert("Responsible: " + _person.Name, "Duty: " + _person.Function, "OK");
        }

        private void MenuItem_ClickedIncome(object sender, EventArgs e)
        {

        }

        private void MenuItem_ClickedDiscount(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btnAction = (Button)sender;
            Shore _shore = (Shore)btnAction.CommandParameter;

            DisplayAlert("Responsible: " + _shore.Name, "Duty: " + _shore.Category, "OK");
        }
    }
}