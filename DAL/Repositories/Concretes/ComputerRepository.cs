using DAL.Context;
using DAL.Entities;
using DAL.Repositories.Abstracts;
using DAL.Singleton;

namespace DAL.Repositories.Concretes
{
    public class ComputerRepository : ComputerBaseRepository
    {
        //Singleton Pattern:
        ComputerStoreContext db = ComputerStoreSingleton.Instance();
        
        public override Computer CreateComputer()
        {
            return new Computer();
        }

        public override Computer GetComputer(int computerId)
        {
            //Eğer bu arama işleminin sonucunda playerId bulunmaz ise geriye null döner. Bu da bize "null references exception" olarak runtime'da sıkıntı çıkarır.
            return db.Computers.Find(computerId);
            /*
            Error	CS0122	'ComputerStoreContext.Computers' is inaccessible due to its protection level
            public DbSet<Computer> Computers {  get; set; }
            */
        }

        public override string SaveComputerDatabase(Computer computer)
        {
            try
            {
                db.Computers.Add(computer);
                db.SaveChanges();
                return $"{computer.Name} veritabanına kayıt edildi.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
