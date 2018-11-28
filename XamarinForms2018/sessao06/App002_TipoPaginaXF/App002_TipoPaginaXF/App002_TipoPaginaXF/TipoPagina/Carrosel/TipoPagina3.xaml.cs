using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App002_TipoPaginaXF.TipoPagina.Carrosel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}

        private void MudarPagina(object sender, EventArgs args)
        {
            //!
            //navigation
            //App.Current.MainPage = new NavigationPage(new Navegation.Page1()) { BarBackgroundColor = Color.BlueViolet};
            //tabbed
            App.Current.MainPage = new Tabed.Abbas();
            //App.Current.MainPage = new NavigationPage(new Master.Master());
        }

    }
}