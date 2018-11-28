using System;
using System.Collections.Generic;
using System.Text;

namespace App005_ToDoApp.Modelos
{
    public class Task
    {
        public int Index { get; set; }
        public string TaskName { get; set; }
        public Nullable<DateTime> DateDone { get; set; }
        public Priorities Prioritie { get; set; }
    }
}
