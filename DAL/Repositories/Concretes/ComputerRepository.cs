using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Abstracts;
using DAL.Singleton;

namespace DAL.Repositories.Concretes
{
    public class ComputerRepository : ComputerBaseRepository
    {
        //Singleton Pattern
        ComputerStoreContext db = ComputerStoreSingleton.Instance();
        
        public override Computer CreateComputer()
        {
            return new Computer();
        }

        public override Computer GetComputer(int computerId)
        {
            throw new NotImplementedException();
        }

        public override string SaveComputerDatabase(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}
