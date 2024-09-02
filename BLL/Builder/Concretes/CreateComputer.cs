using DAL.Builder.Abstracts;
using DAL.Entities;

namespace BLL.Builder.Concretes
{
    public class CreateComputer
    {
        public void BuildComputer(ComputerBuilder computer)
        {
            //TODO: Bir metot oluştur, parametleri id ve ComputerBuilder olsun.
            Console.WriteLine("Anakart Id:");
            int userAnakartId = int.Parse(Console.ReadLine());
            computer.GetAnakartId(userAnakartId);

            Console.WriteLine("Monitor Id:");
            int userMonitorId = int.Parse(Console.ReadLine());
            computer.GetComputerMonitorId(userMonitorId);

            Console.WriteLine("Ekran Kartı Id:");
            int userEkranKartiId = int.Parse(Console.ReadLine());
            computer.GetEkranKartiId(userEkranKartiId);

            Console.WriteLine("Islemci Id:");
            int userIslemciId = int.Parse(Console.ReadLine());
            computer.GetIslemciId(userIslemciId);

            Console.WriteLine("Klavye Id:");
            int userKlavyeId = int.Parse(Console.ReadLine());
            computer.GetKlavyeId(userKlavyeId);

            Console.WriteLine("Mouse Id:");
            int userMouseId = int.Parse(Console.ReadLine());
            computer.GetMouseId(userMouseId);

            Console.WriteLine("Ram Id:");
            int userRamId = int.Parse(Console.ReadLine());
            computer.GetRamId(userRamId);

            Console.WriteLine("SSD Id:");
            int userSsdId = int.Parse(Console.ReadLine());
            computer.GetSSDId(userAnakartId);
        }
    }
}
