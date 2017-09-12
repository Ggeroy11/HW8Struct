using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Menu
    {
        static int count = 0;
        public void ShowMenu()
        {
            Console.WriteLine("Выберите пункт меню");
            int position = 0;
            while (true)
            {
                Console.WriteLine("1 Добавить сотрудника");
                Console.WriteLine("2 Вывод информации");
                Console.WriteLine("3 Поиск Менеджеров чии зарплаты  больше средней зарплаты сотрудников");
                Console.WriteLine("4 вывод информации обо всех сотрудниках зарегестрированных позже начальника");
                Console.WriteLine("5 выход");
                position = Console.Read();
                if (position == 1) {
                    AddEmployee();
                }
                else if (position == 1) {
                    ShowInfoEmployee();
                }
                else if (position == 1) {
                    SearchManagerSalaryUp();
                }
                else if (position == 1) {
                    ShowInfoAllEmployee();
                }
            }
        }
        private bool AddEmployee()
        {

            
            Employee employee= new Employee();
            Console.Clear();
            Console.WriteLine("Введите имя сотрудника ");
            employee.Name = Console.ReadLine();
            if (employee.Name != null)
            {
                Console.WriteLine("Выберите должность");
                Console.WriteLine("1 Босс");
                Console.WriteLine("2 Менеджер");
                Console.WriteLine("3 Сотрудник");
                int position;
                if (!Int32.TryParse(Console.ReadLine(), out position))
                {
                    if (position < 1 || position > 3)
                    {
                        return false;
                    }
                    employee.Position = (Position)position - 1;
                }
                else {
                    return false;
                }
                Console.WriteLine("Введите зарплату");
                int salary;
                if (Int32.TryParse(Console.ReadLine(), out salary))
                {
                    employee.Salary = salary;
                }
                else
                { 
                    return false;
                }
                employee.EmployeeDate = Console.Read();
                if (employee.EmployeeDate == 0)
                {
                    return false;
                }

                
            }

            count++;


            return true;
        }

        private void ShowInfoAllEmployee()
        {
            
        }

        private void SearchManagerSalaryUp()
        {
            
        }

        private void ShowInfoEmployee()
        {

        }

        

    }
        
}
