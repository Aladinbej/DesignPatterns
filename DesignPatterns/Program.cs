using System;
using System.Net.NetworkInformation;
using DesignPatterns.Core;
using DesignPatterns.Core.Strategies;
using DesignPatterns.Models;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory.ExecDelegate(() => "hello".ToUpper());

            Console.WriteLine("Welcome to contacts application");
            string again;
            do
            {
                Console.WriteLine("Please, fill these information");
                string lastName;
                do
                {
                    Console.WriteLine("Enter lastname");
                    lastName = Console.ReadLine();
                } while (lastName == "");

                string firstName;
                do
                {
                    Console.WriteLine("Enter firstname");
                    firstName = Console.ReadLine();
                } while (firstName == "");

                string phone;
                do
                {
                    Console.WriteLine("Enter phone");
                    phone = Console.ReadLine();
                } while (phone == "");

                var contact = new Contact
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Phone = phone
                };

                IStrategy strategy;
                do
                {
                    Console.WriteLine("Enter a strategy (JSON, XML or CSV)");
                    var strategyInput = Console.ReadLine();
                    strategy = Factory.Create(strategyInput);
                } while (strategy is null);

                strategy.Write(contact);
                Console.WriteLine("Contact added!");
                Console.WriteLine("Do you want to add another contact ?");
                again = Console.ReadLine();
            } while (again == "y");
        }
    }
}
