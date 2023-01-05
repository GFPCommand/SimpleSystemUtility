using System.Management;

namespace Helpful.HWs
{
    internal class User
    {
        public User() { }

        public string User_Name { get; private set; }
        public string User_Domain { get; private set; }
        public string User_AccountType { get; private set; }
        public string User_Status { get; private set; }
        public string User_PasswordRequired { get; private set; }
        public string User_SID { get; private set; }

        public void GetUserInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * from Win32_UserAccount");

            foreach (var item in searcher.Get())
            {
                User_Name = item["FullName"].ToString();
                User_Domain = item["Domain"].ToString();
                User_AccountType = item["Name"].ToString();
                User_Status = item["Status"].ToString();
                User_PasswordRequired = item["PasswordRequired"].ToString();
                User_SID = item["SID"].ToString();
            }
        }
    }
}
