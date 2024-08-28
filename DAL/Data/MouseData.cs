using DAL.Entities;

namespace DAL.Data
{
    public class MouseData
    {
        public static List<Mouse> Mice = new List<Mouse>()
        {
            new Mouse{ID=1,Brand="Logitech",Model="G502 HERO",UnitPrice=450.99m,Quantity=25,KdvRate=18m,IsSilentTouch=false,IsWireless=false},
            new Mouse{ID=2,Brand="Razer",Model="DeathAdder V2 Pro",UnitPrice=750.50m,Quantity=18,KdvRate=18m,IsSilentTouch=true,IsWireless=true}
        };
    }
}
