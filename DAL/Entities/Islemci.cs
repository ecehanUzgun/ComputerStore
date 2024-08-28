using DAL.Abstract;

namespace DAL.Entities
{
    public class Islemci:Product
    {
        public int CoreCount { get; set; } // Çekirdek Sayısı
        public double ClockSpeed { get; set; } // Saat Hızı (GHz)
    }
}
