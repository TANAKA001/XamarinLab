using App005_ToDoApp.Controler;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App005_ToDoApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Index : ContentPage
    {
        public Index()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString("dddd, dd MMMM of yyyy");

            //ClearData();

            ViewListTasks(null);

        }

        protected void ClearData() {

            Xamarin.Forms.Application.Current.Properties.Clear();

        }

        protected void BtnCadastro(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Register());
        }

        private void ViewListTasks(DateTime? _dateTasks)
        {
            slTasks.Children.Clear();

            List<Modelos.Task> _taskList = new TaskController().SelectList();

            foreach (var _task in _taskList)
            {
                LoadTaskList(_task);
            }
        }

        protected void LoadTaskList(Modelos.Task _task)
        {

            var layout = new StackLayout { Orientation = StackOrientation.Horizontal, Spacing = 15 };

            var lblIndex = new Label { Text = _task.Index.ToString() };
            //--------------------
            var imageStatus = new Image
            {
                Source = ((String.IsNullOrEmpty(_task.DateDone.ToString())) ?
                                    ((Device.RuntimePlatform == Device.UWP) ? @"Resources/undone.png" : "undone.png")
                                    :
                                    ((Device.RuntimePlatform == Device.UWP) ? @"Resources/done.png" : "done.png")),
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 40,
                WidthRequest = 40,
            };
            if ((String.IsNullOrEmpty(_task.DateDone.ToString())))
            {
                var statusTGRecognizer = new TapGestureRecognizer();

                statusTGRecognizer.Tapped += delegate
                {

                    new TaskController().Done(_task);
                    ViewListTasks(null);
                };

                imageStatus.GestureRecognizers.Add(statusTGRecognizer);
            }
            //--------------------
            var imagePrioridade = new Image
            {
                Source = ((Device.RuntimePlatform == Device.UWP) ? @"Resources/" + _task.Prioritie.IndexPrioritie + ".png" : _task.Prioritie.IndexPrioritie + ".png"),
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 40,
                WidthRequest = 40,
            };
            //--------------------
            var imageBtnDelete = new Image
            {
                Source = ((Device.RuntimePlatform == Device.UWP) ? @"Resources/app_ui (1).png" : "app_ui (1).png"),
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 40,
                WidthRequest = 40,
            };

            var deleteTGRecognizer = new TapGestureRecognizer();

            deleteTGRecognizer.Tapped += delegate
            {

                new TaskController().Delete(_task);
                ViewListTasks(null);

            };

            imageBtnDelete.GestureRecognizers.Add(deleteTGRecognizer);

            //--------------------
            var layoutInt = new StackLayout { Orientation = StackOrientation.Vertical, HorizontalOptions = LayoutOptions.FillAndExpand, Margin = new Thickness(0, 0, 0, 10) };

            var _lbl = new Label { Text = _task.TaskName };//task.name
            layoutInt.Children.Add(_lbl);

            if (!(String.IsNullOrEmpty(_task.DateDone.ToString()))) //task.done exists
            {
                var _lblSub = new Label { Text = "Task done in: _task.DateDone.ToString()", TextColor = Color.LightGray, FontSize = 10 };//task.donedate exists
                layoutInt.Children.Add(_lblSub);
            }

            //--------------------
            layout.Children.Add(lblIndex);

            layout.Children.Add(imageStatus);
            layout.Children.Add(layoutInt);
            layout.Children.Add(imagePrioridade);
            layout.Children.Add(imageBtnDelete);

            slTasks.Children.Add(layout);
        }

        protected void DeleteTask(object sender, EventArgs args)
        {
            //

            DisplayAlert("teste", "it works!!", "fun");
        }


    }
}