using System;
using System.Linq;
using System.Windows.Forms;

namespace MysterySpam
{
    static class StartGUI
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GUI());
        }
    }
}
