using DAL.Entities;

namespace DAL.Data
{
    public class ComputerMonitorData
    {
        public static List<ComputerMonitor> ComputerMonitors = new List<ComputerMonitor>()
        {
            new ComputerMonitor{ID=1,Brand="Dell",Model="UltraSharp U2720Q",UnitPrice=4500.99m,Quantity=8,KdvRate=10m,Size=27},
            new ComputerMonitor{ID=2,Brand="Samsung",Model="Odyssey G7",UnitPrice=5500.75m,Quantity=5,KdvRate=10m,Size=32}
        };
    }
}
