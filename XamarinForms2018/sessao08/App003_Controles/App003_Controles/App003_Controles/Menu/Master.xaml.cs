using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App003_Controles.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : MasterDetailPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private void GoActivitIndicator(object sender, EventArgs e)
        {
            Detail = new Controles.ActivitIndicatorPAge();
        }
        private void GoProgressBar(object sender, EventArgs e)
        {
            Detail = new Controles.ProgressBarrPage();
        }

        private void GoBoxViewPage(object sender, EventArgs e)
        {
            Detail = new Controles.BoxViewPage();
        }

        private void GoLabelPages(object sender, EventArgs e)
        {
            Detail = new Controles.LabelPage();
        }

        private void GoButtonPage(object sender, EventArgs e)
        {
            Detail = new Controles.ButtonPage();
        }

        private void GoEntryEditorPage(object sender, EventArgs e)
        {
            Detail = new Controles.EntryEditorPAge();
        }

        private void DatePickerPageGo(object sender, EventArgs e)
        {
            Detail = new Controles.DatePickerPage();
        }
        private void TimePickerGo(object sender, EventArgs e)
        {
            Detail = new Controles.TimePickerPage();
        }
        private void PickerGo(object sender, EventArgs e)
        {
            Detail = new Controles.PickerPage();
        }
        private void SearchBarPageGo(object sender, EventArgs e)
        {
            Detail = new Controles.SearchBarPage();
        }
        private void SliderStepperPageGo(object sender, EventArgs e)
        {
            Detail = new Controles.SliderStepperPage();
        }
        private void SwitchPageGo(object sender, EventArgs e)
        {
            Detail = new Controles.SwitchPage();
        }
        private void ImagePageGo(object sender, EventArgs e)
        {
            Detail = new Controles.ImagePage();
        }
        private void ListViewGo(object sender, EventArgs e)
        {
            Detail = new Controles.ListViewPage();
        }
        private void TableViewGo(object sender, EventArgs e)
        {
            Detail = new Controles.TableViewPage();
        }
        private void WebViewPageGo(object sender, EventArgs e)
        {
            Detail = new Controles.WebViewPAge();
        }
    }
}