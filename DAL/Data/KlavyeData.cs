using DAL.Entities;

namespace DAL.Data
{
    public class KlavyeData
    {
        public static List<Klavye> Klavyeler = new List<Klavye>()
        {
            new Klavye{ID=1,Brand="Logitech",Model="G Pro X",UnitPrice=1200.50m,Quantity=20,IsWireless=false},
            new Klavye{ID=2,Brand="Razer",Model="BlackWidow V3 Pro",UnitPrice=1500.75m,Quantity=15,KdvRate=18m,IsWireless=true}
        };
    }
}
