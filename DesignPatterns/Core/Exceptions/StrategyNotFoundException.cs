using System;

namespace DesignPatterns.Core.Exceptions
{
    public class StrategyNotFoundException : Exception
    {
        public StrategyNotFoundException(string strategy): base ($"Strategy : {strategy} not found")
        {
        }
    }
}
