using DAL.Abstract;

namespace DAL.Entities
{
    public class Mouse:Product
    {
        public bool IsSilentTouch { get; set; }
        public bool IsWireless { get; set; } //Kablosuz mu?
    }
}
