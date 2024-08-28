using DAL.Context;

namespace DAL.Singleton
{
    public class ComputerStoreSingleton
    {
        private ComputerStoreSingleton() 
        { 
            
        }

        private static ComputerStoreContext _instance;

        public static ComputerStoreContext Instance()
        {
            if (_instance == null) _instance = new ComputerStoreContext();
            return _instance;
        }
    }
}
