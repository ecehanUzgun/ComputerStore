using DAL.Entities;

namespace DAL.Data
{
    public class RamData
    {
        public static List<Ram> Rams = new List<Ram>()
        { 
            new Ram{ID=1,Brand="Corsair",Model="Vengeance LPX",UnitPrice=1200m,Quantity=30,KdvRate=18m,Capacity=16},
            new Ram{ID=2,Brand="G.Skill",Model="Trident Z RGB",UnitPrice=1500.50m,Quantity=20,KdvRate=10m,Capacity=32}
        };
    }
}
