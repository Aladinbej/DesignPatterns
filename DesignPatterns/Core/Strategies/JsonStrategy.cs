using System.Diagnostics;
using System.IO;
using System.Text.Json;
using DesignPatterns.Models;


namespace DesignPatterns.Core.Strategies
{
    public class JsonStrategy : IStrategy
    {
        private static readonly string Path = $"{Constants.OutputFile}json";
        public void Write(Contact contact)
        {
            var jsonString = JsonSerializer.Serialize(contact);
            File.WriteAllText(Path, jsonString);
        }
    }
}