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
	public partial class ImagePage : ContentPage
	{
        public ImagePage()
        {
            InitializeComponent();

            Image _newImage = new Image();

            if (Device.RuntimePlatform == Device.UWP)
            {
                _newImage.Source = ImageSource.FromFile(@"Assets/LargeTile.png");
            }
            else {
                _newImage.Source = ImageSource.FromFile(@"LargeTile.png");
            }
            

            Container.Children.Add(_newImage);
            
		}
	}
}