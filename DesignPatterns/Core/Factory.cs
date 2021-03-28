namespace DesignPatterns.Core
{
    public class Factory
    {
        public static Factory Instance = null;
        
        private Factory()
        {
            
        }

        public Factory GetInstance()
        {
            if (Instance is null)
            {
                Instance = new Factory();
            }

            return Instance;
        }
    }
}