using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service : IService
    {
        private readonly IService2 service2;

        public Service(IService2 service) 
        {
            service2 = service;
        }

        public void Execute()
        {
            Console.WriteLine("Service is executing...");
        }

        public void Execute2()
        {
            service2.Execute(); 
        }
    }
}
