using Helpful.HWs;
using System;
using System.Windows.Forms;

namespace Helpful
{
    public partial class Form1 : Form
    {
        CPU cpuInfo;
        GPU gpuInfo;
        RAM ramInfo;
        Storage storageInfo;
        Motherboard motherboardInfo;
        User userInfo;

        public Form1()
        {
            InitializeComponent();

            cpuInfo = new CPU();
            gpuInfo = new GPU();
            ramInfo = new RAM();
            storageInfo = new Storage();
            motherboardInfo = new Motherboard();
            userInfo = new User();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cpuInfo.GetCpuInfo();
            ramInfo.GetRamInfo();
            motherboardInfo.GetMotherboardInfo();
            gpuInfo.GetGpuInfo();
            userInfo.GetUserInfo();

            AboutCpu();
        }

        private void cpuInfoButton_Click(object sender, EventArgs e)
        {
            AboutCpu();
        }

        private void ramInfoButton_Click(object sender, EventArgs e)
        {
            label1.Text = $"Name: {ramInfo.RAM_Name}";
            label2.Text = $"Manufacturer: {ramInfo.RAM_Manufacturer}";
            label3.Text = $"Capacity: {Math.Round(ramInfo.RAM_Capacity / 1024 / 1024 / 1024)} Gb";
            label4.Text = $"Available: {Math.Round(ramInfo.RAM_Using)} Gb";
            label5.Text = $"Frequency: {ramInfo.RAM_Frequency} MHz";
            label6.Text = $"Voltage: {ramInfo.RAM_Voltage / 1000} V";
        }

        private void storageInfoButton_Click(object sender, EventArgs e)
        {
            label1.Text = $"Drive: {storageInfo.Drives[0].Name}";
            label2.Text = $"Drive type: {storageInfo.Drives[0].DriveType}";
            label3.Text = $"File system: {storageInfo.Drives[0].DriveFormat}";
            label4.Text = $"Available space (User): {storageInfo.Drives[0].AvailableFreeSpace / 1024 / 1024 / 1024} Gb";
            label5.Text = $"Available space (PC): {storageInfo.Drives[0].TotalFreeSpace / 1024 / 1024 / 1024} Gb";
            label6.Text = $"Total size: {storageInfo.Drives[0].TotalSize / 1024 / 1024 / 1024} Gb";
        }

        private void motherboardInfoButton_Click(object sender, EventArgs e)
        {
            label1.Text = $"Name: {motherboardInfo.MB_Name}";
            label2.Text = $"System Name: {motherboardInfo.MB_SystemName}";
            label3.Text = $"SerialNumber: {motherboardInfo.MB_SerialNumber}";
            label4.Text = $"Description: {motherboardInfo.MB_Description}";
            label5.Text = $"Manufacturer: {motherboardInfo.MB_Manufacturer}";
            label6.Text = $"Version: {motherboardInfo.MB_Version}";
        }

        private void gpuInfoButton_Click(object sender, EventArgs e)
        {
            label1.Text = $"Name: {gpuInfo.GPU_Name}";
            label2.Text = $"Video processor: {gpuInfo.GPU_VideoProcessor}";
            label3.Text = $"Driver version: {gpuInfo.GPU_DriverVersion}";
            label4.Text = $"Driver date: {gpuInfo.GPU_DriverDate}";
            label5.Text = $"Adapter RAM: {gpuInfo.GPU_AdapterRAM / 1024 / 1024 + 1} Mb";
            label6.Text = $"Adapter: {gpuInfo.GPU_AdapterCompatibility}";
        }

        private void userInfoButton_Click(object sender, EventArgs e)
        {
            label1.Text = $"Name: {userInfo.User_Name}";
            label2.Text = $"Domain: {userInfo.User_Domain}";
            label3.Text = $"Account type: {userInfo.User_AccountType}";
            label4.Text = $"Status: {userInfo.User_Status}";
            label5.Text = $"Password required: {userInfo.User_PasswordRequired}";
            label6.Text = $"SID: {userInfo.User_SID}";
        }

        private void AboutCpu()
        {
            label1.Text = $"Name: {cpuInfo.CPU_Name}";
            label2.Text = $"Cores: {cpuInfo.CPU_Cores}";
            label3.Text = $"Threads: {cpuInfo.CPU_Threads}";
            label4.Text = $"Stepping: {cpuInfo.CPU_Stepping}";
            label5.Text = $"Frequency: {cpuInfo.CPU_Frequency} MHz";
            label6.Text = $"Max frequency: {cpuInfo.CPU_MaxFrequency} MHz";
        }
    }
}
