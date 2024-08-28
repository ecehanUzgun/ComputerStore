using DAL.Entities;

namespace DAL.Repositories.Abstracts
{
    public abstract class ComputerBaseRepository
    {
        //Create Computer : Bilgisayar bilgileri için nesnenin örneğini ram üzerine alacak ve bu örneği döndürecek. --BUILDER PATTERN
        public abstract Computer CreateComputer();

        //SavePlayerDatabase: Yukarıda alınan örneğin veritabanına kaydını gerçekleştirecek.
        public abstract string SaveComputerDatabase(Computer computer);

        //GetPlayer: Kaydı gerçekleştirilen bilgisayarın bilgilerini getirecek. --SINGLETON PATTERN
        public abstract Computer GetComputer(int computerId);

    }
}
