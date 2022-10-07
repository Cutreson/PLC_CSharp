using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ActUtlTypeLib;

namespace _01_ServoControl
{
    /// <summary>
    /// Driver kết nối với MX Component
    /// </summary>
    public static class MXDriver
    {
        private static ActUtlType plc = new ActUtlType();
        private static bool isConnected;

        /// <summary>
        /// Kết nối với MX Component
        /// </summary>
        /// <param name="logicalStationNumber">Chọn Logical Station</param>
        /// <returns>Return true nếu kết nối thành công</returns>
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
        /// <summary>
        /// Ngắt kết nối với MX Component
        /// </summary>
        /// <returns>Return true nếu ngắt kết nối thành công</returns>
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
        /// <summary>
        /// Kiểm tra kết nối
        /// </summary>
        /// <returns>Return true nếu đã kết nối, return false nếu ngắt kết nối</returns>
        public static bool IsConnected()
        {
            return isConnected;

        }
        /// <summary>
        /// Set data cho PLC
        /// </summary>
        /// <param name="device">Địa chỉ trên PLC</param>
        /// <param name="data">Dữ liệu truyền xuống PLC</param>
        /// <returns>Return true nếu set thành công</returns>
        public static bool SetDevice(string device, short data)
        {
            try
            {
                if (isConnected)
                {
                    plc.SetDevice2(device, data);
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
        /// <summary>
        /// Get data từ PLC
        /// </summary>
        /// <param name="device">Địa chỉ cần lấy data</param>
        /// <param name="data">Data trả về</param>
        /// <returns>Return true nếu lấy data thành công</returns>
        public static bool GetDevice(string device, out short data)
        {
            try
            {
                if (isConnected)
                {
                    plc.GetDevice2(device, out data);
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
    }
}
