using BLL.Builder.Concretes;
using DAL.Entities;
using BLL.Builder;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Anakart:
            //Ekran Kartı:
            //Listele READ
            //Computer CREATE

            //Anakart instance
            //Ekrankart instance
            /*
             --Singleton Pattern
                 Bir nesnenin örneğini sadece bir defa almak için kullanmış olduğumuz tasarım desenidir.
                 1-Nesnenin dışarıdan instance alımı engellenir.
            --Bilgisayarı Console'da Singleton Pattern kullanarak listele.
            */
            /*
             --Builder Pattern
                Computer Builder
             */

            //Kullanıcıdan Id bilgileri alınıp bilgisayar toplanacak.
            ComputerBuilder computerBuilder = new ComputerBuilder();
            

            CreateComputer createComputer = new CreateComputer();

        }
    }
}
