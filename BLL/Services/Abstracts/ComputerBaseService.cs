using DAL.Entities;

namespace BLL.Services.Abstracts
{
    public abstract class ComputerBaseService
    {
        public abstract Computer CreateComputer();
        public abstract Computer GetComputer(int computerId);
        public abstract string SaveComputerDatabase(Computer computer);
    }
}
