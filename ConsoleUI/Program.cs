using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessDemo demo = new AccessDemo();

            demo.PublicDemo(); //will call just the public method

            BadClass bad = new BadClass();
            //bad.creditCardNumber
            //bad.SSN
            //bad._ssn
            bad.Age = 150;
            bad._age = 150;
        }
        private static void SayHello()
        {
            Console.WriteLine("Hello user");
        }
    }
}
