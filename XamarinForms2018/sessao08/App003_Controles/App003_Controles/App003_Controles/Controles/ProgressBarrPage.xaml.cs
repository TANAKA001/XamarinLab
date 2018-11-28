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
	public partial class ProgressBarrPage : ContentPage
	{
		public ProgressBarrPage ()
		{
			InitializeComponent ();
		}

        private void FollowUp(object sender, EventArgs e)
        {
            Bar1.Progress = 1;
            Bar2.ProgressTo(1, 5000, Easing.Linear);
            Bar3.ProgressTo(1, 5000, Easing.CubicIn);
            Bar4.ProgressTo(1, 5000, Easing.SinIn);
            
        }
    }
}