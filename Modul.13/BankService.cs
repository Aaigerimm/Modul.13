using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._13
{
    class BankService
    {
        private ClientQueue clientQueue = new ClientQueue();
        private List<Client> servicedClients = new List<Client>();
        private Random random = new Random();

        public void EnqueueClient()
        {
            string clientName = Guid.NewGuid().ToString().Substring(0, 8);
            string serviceType = GetRandomServiceType();

            Client newClient = new Client(clientName, serviceType);
            clientQueue.Enqueue(newClient);

            Console.WriteLine($"{newClient.Name} обслуживается по услуге {newClient.ServiceType}");
            clientQueue.DisplayQueueStatus();
        }

        public void ServeNextClient()
        {
            if (clientQueue.Any())
            {
                Client nextClient = clientQueue.Dequeue();
                servicedClients.Add(nextClient);

                Console.WriteLine($"{nextClient.Name} обслуживается по услуге {nextClient.ServiceType}.");
                clientQueue.DisplayQueueStatus();
            }
            else
            {
                Console.WriteLine("Очередей нет. Нет клиентов для обслуживания.");
            }
        }

        public void DisplayQueueStatus()
        {
            clientQueue.DisplayQueueStatus();
        }

        public void DisplayServicedClients()
        {
            Console.WriteLine("Обслуженные клиенты:");
            foreach (var client in servicedClients)
            {
                Console.WriteLine($"{client.Name} - {client.ServiceType}");
            }
        }
        private string GetRandomServiceType()
        {
            string[] serviceTypes = { "Credit", "Deposit", "Consultation" };
            return serviceTypes[random.Next(serviceTypes.Length)];
        }
    }
}
