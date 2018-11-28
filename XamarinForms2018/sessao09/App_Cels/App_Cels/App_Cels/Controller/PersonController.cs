using App_Cels.Modelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace App_Cels.Controller
{
    public class PersonController
    {
        public static List<Person> ListPerson() {

            List<Person> _persons = new List<Person> {
                new Person{Id = 1, Name="Mahoei", Function="Comedy", Avatar="avatarDefault.png" },
                new Person{Id = 2, Name="Kairo", Function="Clothes", Avatar="avatarDefault.png" },
                new Person{Id = 3, Name="Keanu", Function="Dishes", Avatar="avatarDefault.png" },
                new Person{Id = 4, Name="Shaneen", Function="MOM", Avatar="avatarDefault.png" }
            };

            return _persons;
        }
    }
}
