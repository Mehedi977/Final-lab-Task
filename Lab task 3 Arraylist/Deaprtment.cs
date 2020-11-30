using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_LabTask
{
    class  faculty
    {
        public string Name { get; set; }

        public string Id { get; set; }

        public faculty() { }
        public faculty(string Name, string Id,)
        {
            this.Name = Name;
            this.Id = Id;

        }
        public void Show()
        {
            Console.WriteLine("Name: " + Name);

            Console.WriteLine("Id: " + Id);
        }
    }
}
