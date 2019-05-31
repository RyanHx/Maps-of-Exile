using System;
using System.IO;
using System.Windows;

namespace PoEMapsViewModel.Helper
{
    public class UserSettings
    {
        public static void SaveSettings()
        {
            Properties.Settings.Default.Save();
        }

        public static void SetNumOfResults(int aNum)
        {
            Properties.Settings.Default.NumOfResults = aNum;
        }

        public static int GetNumOfResults()
        {
            return Properties.Settings.Default.NumOfResults;
        }

        public static bool LoggingIsEnabled()
        {
            return Properties.Settings.Default.LoggingEnabled;
        }

        public static void ToggleLogging()
        {
            Properties.Settings.Default.LoggingEnabled = !Properties.Settings.Default.LoggingEnabled;
        }

        public static void Log(string logString)
        {
            try
            {
                if (LoggingIsEnabled())
                {
                    string path = AppDomain.CurrentDomain.BaseDirectory + @"Logs";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                        File.CreateText(path + @"\Log.txt");
                    }
                    else if (!File.Exists(path + @"\Log.txt"))
                    {
                        File.CreateText(path + @"\Log.txt");
                    }

                    using(StreamWriter sw = File.AppendText(path + @"\Log.txt"))
                    {
                        sw.WriteLine("[" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "] " + logString);
                    }
                }
            }
            catch (Exception)
            {
                if (!Properties.Settings.Default.LoggingFailPrompt)
                {
                    Properties.Settings.Default.LoggingFailPrompt = true;
                }
            }
        }
    }
}
