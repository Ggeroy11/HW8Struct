using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Menu
    {
        Employee[] employee;
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
            Console.Clear();
            Console.WriteLine();
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
