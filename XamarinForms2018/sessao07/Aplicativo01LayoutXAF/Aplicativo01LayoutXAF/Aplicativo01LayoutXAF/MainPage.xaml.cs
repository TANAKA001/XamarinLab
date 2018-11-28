using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Aplicativo01LayoutXAF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void GoPageAbsolute(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Absolute.AbsolutePage());
        }
        private void GoPageGrid(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Grid.GridPage());
        }
        private void GoPageRelative(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Relative.RelativePage());
        }
        private void GoPageScroll(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Scroll.ScrollPage());
        }
        private void GoPageStack(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Layout.Stack.StackPage());
        }

    }
}
