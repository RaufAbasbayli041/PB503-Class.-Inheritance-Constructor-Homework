using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Class._Inheritance__Constructor
{
    public class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public Human()
        {

        }
        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, string surname) : this(name)
        {
            Surname = surname;
        }
        public Human(string name, string surname, int age) : this(name, surname)
        {
            Age = age;
        }

    }
}