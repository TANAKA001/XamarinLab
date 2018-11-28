using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App002_TipoPaginaXF.TipoPagina.Navegation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 ()
		{
			InitializeComponent ();
		}
        private void MudarPagina(object sende, EventArgs args)
        {
            App.Current.MainPage = new Tabed.Abbas();
        }
	}
}