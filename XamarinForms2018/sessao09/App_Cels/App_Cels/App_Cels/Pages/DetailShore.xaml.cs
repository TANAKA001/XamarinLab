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
	public partial class DetailShore : ContentPage
	{
		public DetailShore (Shore shore)
		{
			InitializeComponent ();

            ShoreDetail.Text = shore.Name;

        }
	}
}