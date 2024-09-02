using DAL.Builder.Abstracts;
using DAL.Entities;

namespace BLL.Builder.Concretes
{
    public class ComputerBuilder : BaseComputerBuilder
    {
        public ComputerBuilder()
        {
            _computer = new Computer();
        }

        public override void GetAnakartId(int anakartId)
        {
            _computer.AnakartId = anakartId;
        }

        public override void GetComputerMonitorId(int computerMonitorId)
        {
            _computer.MonitorId = computerMonitorId;
        }

        public override void GetEkranKartiId(int ekranKartiId)
        {
            _computer.EkranKartiId = ekranKartiId;
        }

        public override void GetIslemciId(int islemciId)
        {
            _computer.IslemciId = islemciId;
        }

        public override void GetKlavyeId(int klavyeId)
        {
            _computer.KlavyeId = klavyeId;
        }

        public override void GetMouseId(int mouseId)
        {
            _computer.MouseId = mouseId;
        }

        public override void GetRamId(int ramId)
        {
            _computer.RamId = ramId;
        }

        public override void GetSSDId(int ssdId)
        {
            _computer.SSDId = ssdId;
        }
    }
}
