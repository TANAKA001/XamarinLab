using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Style.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Master : MasterDetailPage
	{
		public Master ()
		{
			InitializeComponent ();
            IsPresented = false;
		}

        private void Button_ImplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.ImplicitStyle());
        }

        private void Button_ExplicitStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.ExplicitStyle());
        }
        private void Button_GlobalStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.GlobalStyle());
        }
        private void Button_DynamicStyle(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.DynamicStyle());
        }
    }
}