using System;
using DesignPatterns.Core.Strategies;
using DesignPatterns.Models;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var monContact = new Contact{FirstName = "Rael",LastName = "Calitro",Phone = "0622013025"};
            IStrategy jsonStrategy = new JsonStrategy();
            IStrategy xmlStrategy = new XmlStrategy();
            IStrategy csvStrategy = new CsvStrategy();
            
            jsonStrategy.Write(monContact);
            
        }
    }
}
