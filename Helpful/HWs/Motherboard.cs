using System.Management;

namespace Helpful.HWs
{
    internal class Motherboard
    {
        public Motherboard() { }

        public string MB_Name { get; private set; }
        public string MB_SystemName { get; private set; }
        public string MB_SerialNumber { get; private set; }
        public string MB_Description { get; private set; }
        public string MB_Manufacturer { get; private set; }
        public string MB_Version { get; private set; }

        public void GetMotherboardInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_MotherboardDevice");
            ManagementObjectSearcher baseBoard = new ManagementObjectSearcher("Select * from Win32_BaseBoard");

            foreach (var item in searcher.Get())
            {
                MB_Name = item["Name"].ToString();
                MB_SystemName = item["SystemName"].ToString();
                MB_Description = item["Description"].ToString();
                
            }

            foreach (var item in baseBoard.Get())
            {
                MB_SerialNumber = item["SerialNumber"].ToString();
                MB_Version = item["Version"].ToString();
                MB_Manufacturer = item["Manufacturer"].ToString();
            }
        }
    }
}