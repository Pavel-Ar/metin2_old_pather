using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Sanchez.Patcher.Source_files
{
    class Starter
    {
        public static void Start()
        {
            if (!File.Exists(Globals.BinaryName))
            {
                MessageBox.Show(Texts.GetText("MISSINGBINARY", Globals.BinaryName));
                return;
            }

            try
            {
                Process startProcess = new Process();
                startProcess.StartInfo.FileName = Globals.BinaryName;
                startProcess.StartInfo.UseShellExecute = false;
                startProcess.Start();
            }
            catch(Exception exception)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", exception.Message));
                Application.Exit();
            }
        }

        public static void Config()
        {
            if (!File.Exists(Globals.ConfigName))
            {
                MessageBox.Show(Texts.GetText("MISSINGCONFIG", Globals.ConfigName));
                return;
            }

            try
            {
                Process startProcess = new Process();
                startProcess.StartInfo.FileName = Globals.ConfigName;
                startProcess.StartInfo.UseShellExecute = false;
                startProcess.Start();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Texts.GetText("UNKNOWNERROR", exception.Message));
                Application.Exit();
            }
        }
    }
}
