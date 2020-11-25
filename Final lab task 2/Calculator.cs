using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Lab_Task2

{
    abstart class calculator

    {
        public string Name { get; set; }

        public string Model { get; set; }

        public calculator() { }
        public Calculator(string name, string model)
        {
            Name = name;

            Model = model;
        }

        public int Sum(int x, int y)
        {
            Console.WriteLine("Enter two numbers for sum");
            Console.ReadKey();
            Console.ReadKey();
            int sum = x + y;
            return sum;
        }