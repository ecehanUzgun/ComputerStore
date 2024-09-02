using DAL.Entities;

namespace DAL.Builder.Abstracts
{
    public abstract class BaseComputerBuilder
    {
        protected Computer _computer; //yalnızca bu sınıfın ve bu sınıfı miras alan diğer sınıfların erişimine açık.
        public Computer NewComputer
        {
            get { return _computer; }
        }
            
        //Anakart
        public abstract void GetAnakartId(int anakartId);

        //Monitor
        public abstract void GetComputerMonitorId(int computerMonitorId);

        //Ekran Kartı
        public abstract void GetEkranKartiId(int ekranKartiId);

        //İslemci
        public abstract void GetIslemciId(int islemciId);

        //Klavye
        public abstract void GetKlavyeId(int klavyeId);

        //Mouse
        public abstract void GetMouseId(int mouseId);

        //Ram
        public abstract void GetRamId(int ramId);

        //SSD
        public abstract void GetSSDId(int ssdId);
    }
}
