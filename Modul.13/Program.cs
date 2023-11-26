using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bankService = new BankService();

            while (true)
            {
                Console.WriteLine("\n1. Добавить клиента в очередь");
                Console.WriteLine("2. Обслужить следующего клиента");
                Console.WriteLine("3. Посмотреть статус очереди");
                Console.WriteLine("4. Посмотреть обслуженных клиентов");
                Console.WriteLine("5. Выйти");

                Console.Write("Введите выбор: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bankService.EnqueueClient();
                        break;
                    case 2:
                        bankService.ServeNextClient();
                        break;
                    case 3:
                        bankService.DisplayQueueStatus();
                        break;
                    case 4:
                        bankService.DisplayServicedClients();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Пожалуйста, попробуйте заново.");
                        break;
                }
            }
        }
    }
}
