using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Cels.Menu
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Main : MasterDetailPage
	{
		public Main ()
		{
			InitializeComponent ();
            
		}

        private void Button_TextCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.TextCellPage());
            IsPresented = false;
        }

        private void Button_ImageCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.ImageCellPage());
            IsPresented = false;
        }

        private void Button_EntryCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.EntryCellPage());
            IsPresented = false;
        }

        private void Button_SwitchCell(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Pages.SwitchCellPAge());
            IsPresented = false;
        }
    }
}