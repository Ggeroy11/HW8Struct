using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct Worker
        {
            public string name;
            public string position;
            public int id;
            public void InfoWorker()
            {
                Console.WriteLine("Имя {0}\n Должность{1}\n Номер Id{2}", name, position, id);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во сотрудников\n");
            int size = Console.Read();
            Worker[] worker = new Worker[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Введите имя сотрудника\n");
                worker[i].name = Console.ReadLine();
                Console.WriteLine("Введите должность\n");
                worker[i].position = Console.ReadLine();
                Console.WriteLine("Введите Номер ID");
                worker[i].id = Console.Read();
                Console.Clear();
            }
            foreach (Worker b in worker)
            {
                b.InfoWorker();
            }
            Console.ReadLine();

        }
    }
}
