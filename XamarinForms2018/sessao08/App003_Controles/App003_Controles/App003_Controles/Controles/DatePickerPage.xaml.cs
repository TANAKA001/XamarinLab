using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App003_Controles.Controles
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DatePickerPage : ContentPage
	{
		public DatePickerPage ()
		{
			InitializeComponent ();
		}

        private void SelectedDate(object sender, DateChangedEventArgs args)
        {
            resultado.Text = "De:" + args.OldDate.ToString("dd/MM/yyyy") + "|| Para:" + args.NewDate.ToString("dd/MM/yyyy");
        }
    }
}