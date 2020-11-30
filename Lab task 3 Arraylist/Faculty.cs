using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task3
{
    class Program
    {


        static void Main(string[] args)
        {
            Faculty f = new Faculty("Tanvir ahmed.", "324532");

            Faculty fac1 = new Faculty("Dr.Asraf ali.,345432");

            Department dept = new Dept("Coe", "2");

            dept.AddFaculty(f, fac1);

            dept.ShowAll();
        }
    }
}