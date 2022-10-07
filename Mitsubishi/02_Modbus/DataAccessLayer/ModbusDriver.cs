using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EasyModbus;

namespace _02_Modbus.DataAccessLayer
{
    public static class ModbusDriver
    {
        private static ModbusClient client = new ModbusClient();
        public static bool Connect()
        {
            try
            {
                client.Connect();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool Connect(string ipAddress, int port)
        {
            try
            {
                client.Connect(ipAddress, port);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool Disconnect()
        {
            try
            {
                client.Disconnect();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool IsConnected()
        {
            return client.Connected;    
        }
        public static bool WriteSingleCoil(int address, bool value)
        {
            try
            {
                if(IsConnected())
                {
                    client.WriteSingleCoil(address, value);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool ReadSingleCoil(int address, out bool value)
        {
            try
            {
                if (IsConnected())
                {
                    bool[] dataRead = client.ReadCoils(address, 1);
                    value = dataRead[0];
                    Console.WriteLine(value);
                    return true;
                }
                else
                {
                    value = false;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                value = false;
                return false;
            }
        }
        public static bool WriteSingleRegister(int address, int value)
        {
            try
            {
                if (IsConnected())
                {
                    client.WriteSingleRegister(address, value);
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
        public static bool ReadHoldingRegister(int address, out int value)
        {
            try
            {
                if (IsConnected())
                {
                    int[] dataRead = client.ReadHoldingRegisters(address, 1);
                    value = dataRead[0];
                    return true;
                }
                else
                {
                    value = 0;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                value = 0;
                return false;
            }
        }
    }
}
