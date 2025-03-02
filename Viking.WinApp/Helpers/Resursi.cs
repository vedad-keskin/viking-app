using Viking.WinApp.Forms;
using System.Resources;

namespace Viking.WinApp.Helpers
{
    public class Resursi
    {
        static ResourceManager Manager = new ResourceManager("Viking.WinApp.Resource1",
                                                    typeof(frmLogin).Assembly);
        public static string Get(string key)
        {
            return Manager.GetString(key);
        }
    }
}
