using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;

namespace _01_ServoControl
{
    public static class MXDriver
    {
        private static ActUtlType plc = new ActUtlType();
        private static bool isConnected;

        
        public static bool Connect(int logicalStationNumber)
        {
            try
            {
                plc.ActLogicalStationNumber = logicalStationNumber;
                if(plc.Open() == 0)
                {
                    isConnected = true;
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
        public static bool Disconnect()
        {
            try
            {
                if(plc.Close() == 0)
                {
                    isConnected = false;
                    return true;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }
        public static bool IsConnected()
        {
            return isConnected;
        }
        public static bool SetDevice(string device, int data)
        {
            try
            {
                if (isConnected)
                {
                    plc.SetDevice(device, data);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool GetDevice(string device, out int data)
        {
            try
            {
                if (isConnected)
                {
                    plc.GetDevice(device, out data);
                    return true;
                }
                else
                {
                    data = 0;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                data = 0;
                return false;
            }
        }

        internal static bool Connect()
        {
            throw new NotImplementedException();
        }
    }
}
