using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using DesignPatterns.Models;


namespace DesignPatterns.Core.Strategies
{
    public class JsonStrategy : IStrategy
    {
        private static readonly string JsonFile = $"{Constants.OutputFile}json";

        public void Write(Contact contact)
        {
            var contacts = ReadContacts();
            contacts.Add(contact);
            // write
            var contactsStr = JsonSerializer.Serialize(contacts);
            File.WriteAllText(JsonFile, contactsStr);
        }

        public List<Contact> ReadContacts()
        {
            if (!File.Exists(JsonFile)) return new List<Contact>();

            var text = File.ReadAllText(JsonFile);
            return JsonSerializer.Deserialize<List<Contact>>(text);
        }
    }
}
