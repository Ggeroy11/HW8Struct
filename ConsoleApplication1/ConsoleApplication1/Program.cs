using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            Employee[] employee;
            int size=0;
            Console.WriteLine("Введите кол-во сотрудников");
            size = Console.Read();
            employee = new Employee[size];
            for (int i=0;i<employee.Length;i++) {
                Console.WriteLine("Введите имя Сотрудника");
                Console.ReadLine();
                employee[i].Name = Console.ReadLine();
                Console.WriteLine("Введите Должность");
                employee[i].Position = Console.ReadLine();
                Console.WriteLine("Введите зароботную плату сотрудника");
                employee[i].Salary = Console.Read();
                Console.WriteLine("Введите возраст");
                Console.ReadLine();
                employee[i].Age = Console.Read();
            }
            foreach (var emp in employee) {
                Console.WriteLine("Имя{0}\nID{1}\n Должность{2}\nЗарплата{3}\nВозраст{4}",emp.Name,emp.id,emp.Position,emp.Salary,emp.Age);
            }
            Console.ReadLine();
        }
            
    }
}
