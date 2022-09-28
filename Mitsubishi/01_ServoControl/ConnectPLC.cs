using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;

namespace _01_ServoControl
{
    public static class ConnectPLC
    {
        public static ActUtlType plc = new ActUtlType();
        
        public static bool Connect(int logicalStationNumber)
        {
            try
            {
                plc.ActLogicalStationNumber = logicalStationNumber;
                if(plc.Open() == 0)
                {
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
    }
}
