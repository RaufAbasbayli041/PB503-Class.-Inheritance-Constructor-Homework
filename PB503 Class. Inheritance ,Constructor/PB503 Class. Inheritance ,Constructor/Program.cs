using PB503_Class._Inheritance__Constructor;
using System.Security.Cryptography.X509Certificates;

namespace PB503_Class._Inheritance__Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher humanTeacher = new Teacher();
            humanTeacher.ShowAllDates("Yusif", "Quluzade", 26, 3000, "PB503, PB403");

            Student std1 = new Student();
            std1.ShowAllDates("Rauf", "Abasbayli", 26, 120, "PB503");
            
        }
    }
}


