using HslCommunication.Profinet.Siemens;
using System.Collections.Generic;

namespace Custom.HydrogenConfigurationSystem.Globals
{
    public static class GlobalConstants
    {
        public const string DefaultPlcIp = "127.0.0.1";
        public const int DefaultPlcPort = 102;
        public const byte DefaultRack = 0;
        public const byte DefaultSlot = 1;
        public const int DefaultReadInterval = 300;
        public const int DefaultReConnectInterval = 2000;
        public const double HydrogenExplosionLowerLimit = 4.0;
        public const double HydrogenExplosionUpperLimit = 75.0;
    }
}
