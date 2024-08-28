using DAL.Entities;

namespace DAL.Data
{
    public class EkranKartiData
    {
        public static List<EkranKarti> EkranKartlari = new List<EkranKarti>()
        {
            new EkranKarti{ID=1,Brand="NVIDIA",Model="GeForce RTX 3080",UnitPrice=12000.00m,Quantity=7,KdvRate=18m},
            new EkranKarti{ID=2,Brand="AMD",Model="Radeon RX 6800 XT",UnitPrice=11000.50m,Quantity=5,KdvRate=18m,MemorySize=16}
        };
    }
}
