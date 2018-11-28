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
    public partial class TableViewPage : ContentPage
    {
        public TableViewPage()
        {
            InitializeComponent();
        }
        private void switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (bkpGeral.On == false)
            {
                bkpImagens.IsEnabled = true;
                bkpChat.IsEnabled = true;
                bkpVideos.IsEnabled = true;
            }
            else
            {
                bkpImagens.IsEnabled = false;
                bkpChat.IsEnabled = false;
                bkpVideos.IsEnabled = false;

                bkpImagens.On = false;
                bkpChat.On = false;
                bkpVideos.On = false;
            }
        }
    }

}