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
	public partial class SwitchPage : ContentPage
	{
		public SwitchPage ()
		{
			InitializeComponent ();
		}

        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (e.Value == true)
            {
                bulb.Source = "lon.png";
            }
            else {
                bulb.Source = "loff.png";
            }
        }
    }
}