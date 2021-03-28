namespace DesignPatterns.Core
{
    public class Factory
    {
        private static Factory _instance;
        public static Factory Instance => _instance ??= new Factory();
        private Factory() {}
    }
}
