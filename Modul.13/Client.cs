using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._13
{          class Client
        {
            public string Name { get; }
            public string ServiceType { get; }

            public Client(string name, string serviceType)
            {
                Name = name;
                ServiceType = serviceType;
            }
        }
    }
