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
	public partial class PickerPage : ContentPage
	{
		public PickerPage()
		{
			InitializeComponent ();

            List<string> valores = new List<string>(new string[]{"selecione","aa","bb","cc","dd"});

            foreach (var item in valores)
            {
                teste.Items.Add(item);
                teste.SelectedIndex = 0;
            }

		}

        private void SiFy_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            Picker obj = (Picker)sender;
            DisplayAlert("",obj.SelectedItem.ToString(), "ok");
            
        }
    }
}