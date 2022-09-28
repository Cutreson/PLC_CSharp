using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ServoControl.BusinessLogicLayer
{
    public static class PLCConnector
    {
        public static bool Connect(int logicalStationNumber)
        {
            return MXDriver.Connect(logicalStationNumber);
        }
        public static bool Disconnect()
        {
            return MXDriver.Disconnect();
        }
        public static bool IsConnected()
        {
            return MXDriver.IsConnected();
        }
        public static bool SetDevice(string device, int data)
        {
            return MXDriver.SetDevice(device, data);
        }
        public static bool GetDevice(string device, out int data)
        {
            return MXDriver.GetDevice(device, out data);
        }
    }
}
