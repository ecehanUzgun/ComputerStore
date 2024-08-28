namespace DAL.Entities
{
    public class Computer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //Foreign Key
        public int AnakartId { get; set; }
        public Anakart Anakart { get; set; }
        public int EkranKartiId { get; set; }
        public EkranKarti EkranKarti { get; set; }
        public int IslemciId { get; set; }
        public Islemci Islemci { get; set; }
        public int KlavyeId { get; set; }
        public Klavye Klavye { get; set; }
        public int MonitorId { get; set; }
        public ComputerMonitor ComputerMonitor { get; set; }
        public int MouseId { get; set; }
        public Mouse Mouse { get; set; }
        public int RamId { get; set; }
        public Ram Ram { get; set; }
        public int SSDId { get; set; }
        public SSD SSD { get; set;}
    }
}
