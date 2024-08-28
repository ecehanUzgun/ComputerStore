using DAL.Entities;

namespace DAL.Data
{
    public class IslemciData
    {
        public static List<Islemci> Islemciler = new List<Islemci>
        {
            new Islemci{ID=1,Brand="Intel",Model="Core i9-11900K",UnitPrice=7000m,Quantity=12,KdvRate=18m,CoreCount=8,ClockSpeed=3.5},
            new Islemci{ID=2,Brand="AMD",Model="Ryzen 9 5950X",UnitPrice=8500.50m,Quantity=10,KdvRate=10m,CoreCount=16,ClockSpeed=3.4}
        };
    }
}
