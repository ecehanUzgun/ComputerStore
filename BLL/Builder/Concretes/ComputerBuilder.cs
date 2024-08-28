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
            throw new NotImplementedException();
        }

        public override void GetComputerMonitorId(int computerMonitorId)
        {
            throw new NotImplementedException();
        }

        public override void GetEkranKartiId(int ekranKartiId)
        {
            throw new NotImplementedException();
        }

        public override void GetIslemciId(int islemciId)
        {
            throw new NotImplementedException();
        }

        public override void GetKlavyeId(int klavyeId)
        {
            throw new NotImplementedException();
        }

        public override void GetMouseId(int mouseId)
        {
            throw new NotImplementedException();
        }

        public override void GetRamId(int ramId)
        {
            throw new NotImplementedException();
        }

        public override void GetSSDId(int ssdId)
        {
            throw new NotImplementedException();
        }
    }
}
