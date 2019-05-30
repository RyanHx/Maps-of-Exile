using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
