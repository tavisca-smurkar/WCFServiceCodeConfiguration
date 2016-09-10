using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace ECFServiceHost
{
    class Program
    {
        static void Main(string[] args) 
        {
            ServiceHost host = new ServiceHost(typeof(CounterService));
            host.Open();
            Console.WriteLine("Service is started at {0}", DateTime.Now);
            Console.ReadLine();
                 
        }
    }
}
