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
	public partial class ImageCellPage : ContentPage
    {
		public ImageCellPage ()
		{
             InitializeComponent ();

            ListAvatar.ItemsSource = PersonController.ListPerson();
        }
	}
}