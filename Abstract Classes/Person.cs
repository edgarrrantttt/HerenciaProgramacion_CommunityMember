using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaProgramacion
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string SurName {get; set; }
        public string Sex { get; set; }

        public Person(string name, string surname, string sex)
        {
            Name = name;
            SurName = surname;
            Sex = sex;
        }

    }

}