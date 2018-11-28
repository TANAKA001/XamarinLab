using App005_ToDoApp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App005_ToDoApp.Controler
{
    public class TaskController
    {
        private List<Modelos.Task> _listTask { get; set; }

        public void Save(Modelos.Task _task)
        {
            _listTask = SelectList();

            _listTask.Add(_task);

            WriteDown(_listTask);
        }
        public void SelectSingle(Modelos.Task _task)
        {

        }

        public List<Modelos.Task> SelectList()
        {
            return CheckList();
        }

        public void Delete(Modelos.Task _task)
        {
            _listTask = CheckList();
            _listTask.RemoveAt(_task.Index);
            WriteDown(_listTask);
        }

        public void Done(Modelos.Task _task)
        {
            _listTask = CheckList();
            _listTask.RemoveAt(_task.Index);
            _task.DateDone = DateTime.Now;

            _listTask.Add(_task);

            WriteDown(_listTask);

        }

        public int SizeListTask() {

            _listTask = CheckList();

            return _listTask.Count;
        }

        public void WriteDown(List<Modelos.Task> _listTask)
        {
            if (App.Current.Properties.ContainsKey("Tasks"))
            {
                App.Current.Properties.Remove("Tasks");
            }

            string _taskListJson = JsonConvert.SerializeObject(_listTask);

            App.Current.Properties.Add("Tasks", _taskListJson);

        }
        private List<App005_ToDoApp.Modelos.Task> CheckList()
        {
            if (App.Current.Properties.ContainsKey("Tasks"))
            {
                string jsonVal = (string)App.Current.Properties["Tasks"];
                List<Modelos.Task> _list = JsonConvert.DeserializeObject<List<Modelos.Task>>(jsonVal);

                return _list;
            }
            return new List<Modelos.Task>();
        }
    }
}
