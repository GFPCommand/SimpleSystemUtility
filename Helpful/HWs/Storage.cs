using System.IO;

namespace Helpful.HWs
{
    internal class Storage
    {
        DriveInfo[] drives = DriveInfo.GetDrives();

        public Storage() 
        {
            Drives = drives;
        }

        public DriveInfo[] Drives{ get; private set; }
    }
}
