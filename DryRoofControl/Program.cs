using System;
using System.Threading;
using ASCOM.DeviceInterface;
using ASCOM.DriverAccess;
using DryRoofControl.ASCOMHelpers;
using DryRoofControl.Configuration;
using DryRoofControl.DryRoof;

namespace DryRoofControl
{
    class Program
    {
        private static Config config;

        static void Main(string[] args)
        {
            config = Config.LoadConfig();
            config.Display();
        }
    }
}
