using DAL.Entities;

namespace DAL.Data
{
    public class SSDData
    {
        public static List<SSD> SSDs = new List<SSD>()
        { 
            new SSD{ID=1, Brand="Samsung", Model="970 EVO Plus",UnitPrice=2000m,Quantity=15,KdvRate=18m,Capacity=1000},
            new SSD{ID=2, Brand="Western Digital", Model="WD Black SN850",UnitPrice=2500.75m,Quantity=10,KdvRate=10m,Capacity=2000}
        };
    }
}
