using System.Management;

namespace Helpful.HWs
{
    internal class GPU
    {
        public GPU() { }

        public string GPU_Name { get; private set; }
        public string GPU_VideoProcessor { get; private set; }
        public string GPU_DriverVersion { get; private set; }
        public uint GPU_AdapterRAM { get; private set; }
        public string GPU_AdapterCompatibility { get; private set; }
        public string GPU_DriverDate { get; private set; }

        public void GetGpuInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_VideoController");

            foreach (var item in searcher.Get())
            {
                GPU_Name = item["Name"].ToString();
                GPU_VideoProcessor = item["VideoProcessor"].ToString();
                GPU_DriverVersion = item["DriverVersion"].ToString();
                GPU_AdapterRAM = uint.Parse(item["AdapterRAM"].ToString());
                GPU_AdapterCompatibility = item["AdapterCompatibility"].ToString();
                GPU_DriverDate = item["DriverDate"].ToString();
            }

            GPU_DriverDate = GPU_DriverDate.Substring(0, GPU_DriverDate.Length - 17);
            GPU_DriverDate = GPU_DriverDate.Insert(4, ".");
            GPU_DriverDate = GPU_DriverDate.Insert(7, ".");
        }
    }
}
