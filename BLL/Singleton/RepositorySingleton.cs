using DAL.Context;
using DAL.Repositories.Concretes;

namespace BLL.Singleton
{
    public class RepositorySingleton
    {
        private RepositorySingleton()
        {

        }

        private static ComputerRepository _instance;

        public static ComputerRepository Instance()
        {
            if (_instance == null) _instance = new ComputerRepository();
            return _instance;
        }
    }
}
