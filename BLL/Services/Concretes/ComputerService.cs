using BLL.Services.Abstracts;
using BLL.Singleton;
using DAL.Entities;
using DAL.Repositories.Concretes;

namespace BLL.Services.Concretes
{
    internal class ComputerService : ComputerBaseService
    {
        //Singleton Pattern
        ComputerRepository computerRepository = RepositorySingleton.Instance();  

        public override Computer CreateComputer()
        {
            return computerRepository.CreateComputer();
        }

        public override Computer GetComputer(int computerId)
        {
            return computerRepository.GetComputer(computerId);
        }

        public override string SaveComputerDatabase(Computer computer)
        {
            return computerRepository.SaveComputerDatabase(computer);
        }
    }
}
