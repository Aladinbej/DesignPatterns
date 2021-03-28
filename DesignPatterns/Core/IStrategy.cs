using DesignPatterns.Models;

namespace DesignPatterns.Core
{
    public interface IStrategy
    {
        void Write(Contact contact);
    }
}