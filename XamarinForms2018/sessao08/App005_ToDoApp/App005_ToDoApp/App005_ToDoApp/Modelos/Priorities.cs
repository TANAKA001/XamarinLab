using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App005_ToDoApp.Modelos
{
    public class Priorities
    {
        public Priorities() { }
        public int IndexPrioritie { get; set; }
        public string NamePrioritie
        {
            get
            
                ;
                //return PrioritieSelected(this.IndexPrioritie);
            
            set
            
                ;

            
        }
        public static Dictionary<int, string> PrioritiesValues()
        {
            return new Dictionary<int, string> {
                { 1,"Urgent and important"},
                { 2,"Urgent but NOT important"},
                { 3,"NOT Urgent but important"},
                { 4,"NOT Urgent and NOT important"}
            };
        }
        public static String PrioritieSelected(int index)
        {

            return PrioritiesValues()[index];
        }
    }
}
