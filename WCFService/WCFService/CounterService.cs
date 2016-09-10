using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class CounterService : ICounterService
    {
        int counter = 0;
        public int IncrementNumber()
        {
            return counter++;
        }
    }
}
