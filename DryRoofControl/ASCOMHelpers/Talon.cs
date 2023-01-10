using ASCOM.DeviceInterface;
using DryRoofControl.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DryRoofControl.ASCOMHelpers
{
    public abstract class Talon: IDisposable
    { 
        public enum RoofState
        {
            Open, Closed, Opening, Closing, Error, Unknown
        }

        protected abstract bool Connect();

        protected abstract bool Disconnect();

        public static bool IsTalonLoaded(Config config)
        {
            Process[] p = Process.GetProcessesByName(config.ProcessName);
            if (p.Length == 0) return false;
            return true;
        }

        public abstract RoofState State();

        public abstract void Goto(double howFar);

        public abstract void Open();

        public abstract void Close();

        public abstract void Abort();

        public abstract void Dispose();

    }
}
