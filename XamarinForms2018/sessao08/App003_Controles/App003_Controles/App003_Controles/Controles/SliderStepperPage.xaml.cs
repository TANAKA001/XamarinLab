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
	public partial class SliderStepperPage : ContentPage
	{
		public SliderStepperPage ()
		{
			InitializeComponent ();
		}

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            string comentario = "";
            Color _color = new Color();
            _color = Color.Black;
            switch (e.NewValue)
            {
                case 1:
                    _color = Color.Red;
                     comentario = "No one is perfect...";
                    break;
                case 2:
                    _color = Color.Red;
                    comentario = "It's something to start...";
                    break;
                case 3:
                    _color = Color.Purple;
                    comentario = "One more one less... I know I am better...";
                    break;
                case 4:
                    _color = Color.Purple;
                    comentario = "Don't be shy... You know I am aboove the medium...";
                    break;
                case 5:
                    _color = Color.Blue;
                    comentario = "Living in the edge!";
                    break;
                case 6:
                    _color = Color.Blue;
                    comentario = "we are warming up here!";
                    break;
                case 7:
                    _color = Color.Green;
                    comentario = "Ok... I forgive you... lol";
                    break;
                case 8:
                    _color = Color.Green;
                    comentario = "2 near to the perfection...";
                    break;
                case 9:
                    _color = Color.Orange;
                    comentario = "Don't stop now!!";
                    break;
                case 10:
                    _color = Color.Gold;
                    comentario = "wow... really am I a demigod? lol";
                    break;
                default:
                    comentario = "Selecione uma nota!";
                    break;
            }

            slideResult.TextColor = _color;

            slideResult.Text = (e.NewValue > 0) ? e.NewValue.ToString() + " - " + comentario : comentario;
        }
    }
}