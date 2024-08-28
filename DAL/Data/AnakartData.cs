using DAL.Entities;

namespace DAL.Data
{
    public class AnakartData
    {
        public static List<Anakart> Anakartlar = new List<Anakart>()
        {
            new Anakart{ID=1,Brand="Asus",Model="ROG Strix B550-F",UnitPrice=2000m,Quantity=10,KdvRate=18m},
            new Anakart{ID=2,Brand="MSI",Model="MAG B550 TOMAHAWK",UnitPrice=1850.75m,Quantity=15,KdvRate=18m}
        };
    }
}
