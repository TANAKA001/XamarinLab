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
	public partial class WebViewPAge : ContentPage
	{
		public WebViewPAge ()
		{
			InitializeComponent ();
		}

        private void BtnGo_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(site.Text))
            {
                Browser.Source = site.Text;
            }
        }
        private void BtnPrev_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoBack)
            {
                Browser.GoBack();
            }
        }
        private void BtnForw_Clicked(object sender, EventArgs e)
        {
            if (Browser.CanGoForward)
            {
                Browser.GoForward();
            }
        }
        private void webLoaded(object sender, EventArgs e)
        {
            status.Text = "Finalizado";
            Bar.IsVisible = false;
             Bar.Progress = 0;
        }
        private void webLoading(object sender, EventArgs e)
        {
            status.Text = "Carregando...";
            Bar.IsVisible = true;
            Bar.ProgressTo(1, 5000, Easing.Linear);
           
        }
    }
}