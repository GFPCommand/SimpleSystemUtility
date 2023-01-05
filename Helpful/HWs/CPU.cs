using System.Management;

namespace Helpful.HWs
{
    internal class CPU
    {
        public CPU()
        {

        }

        public string CPU_Name{ get; private set; }
        public int CPU_Cores { get; private set; }
        public int CPU_Threads { get; private set; }
        public string CPU_Stepping { get; private set; }
        public string CPU_Frequency { get; private set; }
        public string CPU_MaxFrequency { get; private set; }

        public void GetCpuInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_Processor");

            foreach (var item in searcher.Get())
            {
                CPU_Name = item["Name"].ToString();
                CPU_Cores = int.Parse(item["NumberOfCores"].ToString());
                CPU_Threads = int.Parse(item["NumberOfLogicalProcessors"].ToString());
                CPU_Stepping = item["Stepping"].ToString();
                CPU_Frequency = item["CurrentClockSpeed"].ToString();
                CPU_MaxFrequency = item["MaxClockSpeed"].ToString();
            }
        }

    }
}