using System;
using DesignPatterns.Core.Exceptions;
using DesignPatterns.Core.Strategies;

namespace DesignPatterns.Core
{
    public class Factory
    {
        public delegate string CustomDelegate();

        private static Factory _instance;
        public static Factory Instance => _instance ??= new Factory();

        private Factory()
        {
        }

        public static IStrategy Create(string strategy)
        {
            var s = strategy.ToUpper();
            return s switch
                {
                    "JSON" => new JsonStrategy(),
                    "XML" => new XmlStrategy(),
                    "CSV" => new CsvStrategy(),
                    _ => null
                };
        }

        public static void ExecDelegate(CustomDelegate del)
        {
            var text = del();
            Console.WriteLine(text);
        }
    }
}
