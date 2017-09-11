using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public struct Employee
    {
        public Guid id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }

        public void EmployeeInfo() {
            Console.WriteLine("Имя {0}\nВозраст{1}\n id {2}", Name, Age, id);

        }
        

        


    }
}
