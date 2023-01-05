using System.Management;

namespace Helpful.HWs
{
    internal class RAM
    {
        public RAM() { }

        public string RAM_Name{ get; private set; }
        public string RAM_Manufacturer{ get; private set; }
        public double RAM_Capacity { get; private set; }
        public double RAM_Using { get; private set; }
        public int RAM_Frequency { get; private set; }
        public double RAM_Voltage { get; private set; }

        public void GetRamInfo()
        {
            double tmpCapacity = 0;

            double divider = 1;

            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_PhysicalMemory");
            ManagementObjectSearcher ramSearch = new ManagementObjectSearcher("Select * from Win32_PhysicalMemoryArray");
            ManagementObjectSearcher totalRamSearch = new ManagementObjectSearcher("Select TotalPhysicalMemory from Win32_ComputerSystem");

            foreach (var item in totalRamSearch.Get())
            {
                RAM_Capacity = double.Parse(item["TotalPhysicalMemory"].ToString());
            }

            foreach (var item in ramSearch.Get())
            {
                RAM_Name = item["Name"].ToString();
                RAM_Using = double.Parse(item["Use"].ToString());
            }

            foreach (var item in searcher.Get())
            {
                divider = double.Parse(item["Capacity"].ToString());
                RAM_Frequency = int.Parse(item["Speed"].ToString());
                RAM_Manufacturer = item["Manufacturer"].ToString();
                RAM_Voltage = double.Parse(item["MaxVoltage"].ToString());
            }

            tmpCapacity = RAM_Capacity / divider;

            RAM_Using *= tmpCapacity;
        }
    }
}
