using DLWMS.WinApp.Forms;
using System.Resources;

namespace DLWMS.WinApp.Helpers
{
    public class Resursi
    {
        static ResourceManager Manager = new ResourceManager("DLWMS.WinApp.Resource1",
                                                    typeof(frmLogin).Assembly);
        public static string Get(string key)
        {
            return Manager.GetString(key);
        }
    }
}
