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
	public partial class EntryEditorPAge : ContentPage
	{
		public EntryEditorPAge ()
		{
			InitializeComponent ();

            txtEntrada.TextChanged += delegate (object sender, TextChangedEventArgs args)
            {
                lblDuplicado.Text = args.NewTextValue;
            };

            txtComentario.Completed += delegate (object sendere, EventArgs args)
            {
               lblQtdChtr.Text = txtComentario.Text.Length.ToString();

            };

		}
	}
}