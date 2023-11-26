using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._13
{
    class ClientQueue
    {
        private Queue<Client> clients = new Queue<Client>();

        public void Enqueue(Client client)
        {
            clients.Enqueue(client);
        }

        public Client Dequeue()
        {
            return clients.Dequeue();
        }
        public bool Any()
        {
            return clients.Any();
        }

        public void DisplayQueueStatus()
        {
            if (clients.Any())
            {
                Console.WriteLine("Статус очереди:");
                foreach (var client in clients)
                {
                    Console.WriteLine($"{client.Name} - {client.ServiceType}");
                }
            }
            else
            {
                Console.WriteLine("Очередей нет.");
            }
        }
    }
}
