using DryRoofControl.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryRoofControl.ASCOMHelpers
{
    public class Talon
    {
        public static bool IsTalonLoaded(Config config)
        {
            Process[] p = Process.GetProcessesByName(config.ProcessName);
            if (p.Length == 0) return false;
            return true;
        }
    }
}
