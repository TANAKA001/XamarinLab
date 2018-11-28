using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App005_ToDoApp.Modelos;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App005_ToDoApp.Controler;

namespace App005_ToDoApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        private int Prioritie { get; set; }
        public Register()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString("dddd, dd MMMM of yyyy");
            GeraLayout();
        }

        protected void GeraLayout()
        {

            foreach (var item in Priorities.PrioritiesValues())
            {
                var _stackLayout = new StackLayout { Spacing = 10, Orientation = StackOrientation.Horizontal };
                //0
                string path = ((Device.RuntimePlatform == Device.UWP) ? @"Resources/" + item.Key.ToString() + ".png" : item.Key.ToString() + ".png");
                var imageBtnPrioritie = new Image
                {
                    Source = path,
                    VerticalOptions = LayoutOptions.Center,
                    HeightRequest = 30,
                    WidthRequest = 40,
                };
                //1
                var _label = new Label { Text = item.Value, HorizontalOptions = LayoutOptions.FillAndExpand, TextColor = Color.Black, Margin = new Thickness(0, 10, 0, 0) };

                //2
                var _idPrioritie = new Label { Text = item.Key.ToString().Trim(), HorizontalOptions = LayoutOptions.FillAndExpand, TextColor = Color.Black, Margin = new Thickness(0, 0, 0, 10), IsVisible = false };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += TapedPrioritie;

                _stackLayout.Children.Add(imageBtnPrioritie);//0
                _stackLayout.Children.Add(_label);//1
                _stackLayout.Children.Add(_idPrioritie);//2

                _stackLayout.GestureRecognizers.Add(tapGestureRecognizer);//add event

                SLPriorities.Children.Add(_stackLayout);
            }
        }

        private void TapedPrioritie(object sender, EventArgs args)
        {
            var _stacks = SLPriorities.Children;

            foreach (var line in _stacks)
            {
                var lblPrioritie = ((StackLayout)line).Children[1] as Label;

                lblPrioritie.TextColor = Color.Gray;

            }
            ((Label)((StackLayout)sender).Children[1]).TextColor = Color.Black;
            string _idPrioritie = ((Label)((StackLayout)sender).Children[2]).Text;

            this.Prioritie = Convert.ToInt32(_idPrioritie);


        }

        private void RegisterTask(object sender, EventArgs args)
        {
            if (TxtName.Text.Trim().Length > 0 && this.Prioritie > 0)
            {
                TaskController _tskList = new TaskController();


                Modelos.Priorities _prioritie = new Priorities();
                _prioritie.IndexPrioritie = this.Prioritie;
                _prioritie.NamePrioritie = Priorities.PrioritieSelected(this.Prioritie);

                Modelos.Task _task = new Modelos.Task();
                _task.DateDone = null;
                _task.Index = _tskList.SizeListTask(); /*take the last saved task add one and...*/
                _task.TaskName = TxtName.Text.Trim();
                _task.Prioritie = _prioritie;/*update critic task image*/

                new TaskController().Save(_task);

                App.Current.MainPage = new NavigationPage(new Index());
            }
            else
            {
                DisplayAlert("ERROR", "Please, infomr the name of the task as also a prioritie!", "Gotcha!");
            }

        }

    }
}