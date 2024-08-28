using DAL.Entities;

namespace DAL.Builder.Abstracts
{
    public abstract class ComputerBuilder
    {
        private Computer _computer; 
        public Computer NewComputer
        {
            get { return _computer; }
        }

        //Anakart
        public abstract void AnakartId();

        //Monitor
        public abstract void ComputerMonitorId();

        //Ekran Kartı
        public abstract void EkranKartiId();

        //İslemci
        public abstract void IslemciId();

        //Klavye
        public abstract void KlavyeId();

        //Mouse
        public abstract void MouseId();

        //Ram
        public abstract void RamId();

        //SSD
        public abstract void SSDId();
    }
}
