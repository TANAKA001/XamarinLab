using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App002_TipoPaginaXF.TipoPagina.Tabed
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Abbas : TabbedPage
	{
		public Abbas ()
		{
			InitializeComponent ();

            Children.Add(new NavigationPage(new Navegation.Page3()){ Title="Item 003"});
		}
	}
}