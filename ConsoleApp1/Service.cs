using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service : IService
    {
        public void Execute()
        {
            Console.WriteLine("Service is executing...");
        }

        public void ExecuteService2()
        {
            IService2 service2 = new Service2();
            service2.Execute();
        }
    }
}
