﻿using Cyclic.Redundancy.Check;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Linq;

namespace Sanchez.Patcher.Source_files
{
    class Common
    {
        public static void ChangeStatus(string Key, params string[] Arguments)
        {
            Globals.pForm.Status.Text = Texts.GetText(Key, Arguments);
        }

        public static void UpdateCompleteProgress(long Value)
        {
            if (Value < 0 || Value > 100)
                return;

            Globals.pForm.completeProgress.Value = Convert.ToInt32(Value);
            Globals.pForm.completeProgressText.Text = Texts.GetText("COMPLETEPROGRESS", Value);
        }

        public static void UpdateCurrentProgress(long Value, double Speed)
        {
            if (Value < 0 || Value > 100)
                return;

            Globals.pForm.currentProgress.Value = Convert.ToInt32(Value);
            Globals.pForm.currentProgressText.Text = Texts.GetText("CURRENTPROGRESS", Value, Speed.ToString("0.00"));
        }

        public static string GetHash(string Name)
        {
            if (Name == string.Empty)
                return string.Empty;

            CRC crc = new CRC();

            string Hash = string.Empty;

            using (FileStream fileStream = File.Open(Name, FileMode.Open))
            {
                foreach (byte b in crc.ComputeHash(fileStream))
                {
                    Hash += b.ToString("x2").ToLower();
                }
            }

            return Hash;
        }

        public static void EnableStart()
        {
            Globals.pForm.Start.Enabled = true;
            Globals.pForm.Start.BackgroundImage = Properties.Resources.btn_startgame_up;
            Globals.pForm.Config.Enabled = true;
            Globals.pForm.Config.BackgroundImage = Properties.Resources.btn_settings_up;
        }

        public static bool IsGameRunning()
        {
            return Process.GetProcessesByName(Globals.BinaryName).FirstOrDefault(p => p.MainModule.FileName.StartsWith("")) != default(Process);
        }
    }
}
