using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Class._Inheritance__Constructor
{
    public class Student : Human
    {
        public int Grant;
        public string GroupNumber;
        public Student()
        {

        }
        public Student(string name) : base(name)
        {

        }
        public Student(string name, string surname) : base(name, surname)
        {

        }
        public Student(string name, string surname, int age) : base(name, surname, age)
        {

        }
        public Student(string name, string surname, int age, int grant) : this(name, surname, age)
        {
            Grant = grant;
        }
        public Student(string name, string surname, int age, int grant, string groupNumber) : this(name, surname, age, grant)
        {
            GroupNumber = groupNumber;
        }

        public void ShowAllDates(string name, string surname, int age, int grant, string groupNumber)
        {
            Console.WriteLine($"{name}, {surname}, {age}, {grant}, {groupNumber} ");
        }
    }
}
