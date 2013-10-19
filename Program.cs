using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TargetCheck
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            IconHandler iHandler = new IconHandler();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (iHandler)
            {
                iHandler.Display();
                Application.Run();
            }
        }
    }
}
