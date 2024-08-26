namespace DAL.Abstract
{
    //Base Class
    public abstract class Product
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal KdvRate { get; set; }
    }
}
