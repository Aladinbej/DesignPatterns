using DesignPatterns.Models;

namespace DesignPatterns.Core.Strategies
{
    public interface IStrategy
    {
        void Write(Contact contact);
    }
}
