using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;
using DesignPatterns.Models;

namespace DesignPatterns.Core.Strategies
{
    public class XmlStrategy : IStrategy
    {
        private static readonly string XmlFile = $"{Constants.OutputFile}xml";

        public void Write(Contact contact)
        {
            // read
            var contacts = ReadContacts();
            contacts.Add(contact);

            // write
            using var wr = new StreamWriter(XmlFile);
            var ser = new XmlSerializer(typeof(List<Contact>));
            ser.Serialize(wr, contacts);
        }

        public List<Contact> ReadContacts()
        {
            if (!File.Exists(XmlFile)) return new List<Contact>();
            var ser = new XmlSerializer(typeof(List<Contact>));
            using var reader = XmlReader.Create(XmlFile);
            return (List<Contact>) ser.Deserialize(reader);
        }
    }
}
