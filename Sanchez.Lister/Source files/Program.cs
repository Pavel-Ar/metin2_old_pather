using System;
using System.Windows.Forms;

namespace Sanchez.Lister
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new lForm());
        }
    }
}
