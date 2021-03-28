using System.Collections.Generic;
using DesignPatterns.Models;

namespace DesignPatterns.Core.Strategies
{
    public class CsvStrategy : IStrategy
    {
        public void Write(Contact contact)
        {
            throw new System.NotImplementedException();
        }

        public List<Contact> ReadContacts()
        {
            throw new System.NotImplementedException();
        }
    }
}
