using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Class._Inheritance__Constructor
{
    public class Teacher : Human
    {
        public double Salary;
        public string[] Groups;
        public Teacher()
        {

        }
        public Teacher(string name) : base(name)
        {

        }
        public Teacher(string name, string surname) : base(name, surname)
        {

        }
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public Teacher(string name, string surname, int age, double salary) : this(name, surname, age)
        {
            Salary = salary;
        }
        public Teacher(string name, string surname, int age, double salary, string[] groups) : this(name, surname, age, salary)
        {
            Groups = groups;
        }
        public void ShowAllDates(string name, string surname, int age, double salary, params string[] groups)
        {
            Console.Write($"{name} , {surname}, {age}, {salary}, ");
            foreach (var group in groups)
            {
                Console.Write(group + ".");
            }
            Console.WriteLine();
        }
    }

}
