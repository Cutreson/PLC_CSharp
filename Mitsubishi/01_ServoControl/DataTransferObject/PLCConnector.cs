using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ServoControl.BusinessLogicLayer
{
    /// <summary>
    /// Connector kết nối đến các dòng PLC khác nhau, trong ví dụ này chỉ kết nối với MX Component
    /// </summary>
    public static class PLCConnector
    {
        /// <summary>
        /// Kết nối với PLC (Sử dụng cho PLC Mitsubishi, dùng MX Component)
        /// </summary>
        /// <param name="logicalStationNumber">Chọn Logical Station</param>
        /// <returns>Return true nếu kết nối thành công</returns>
        public static bool Connect(int logicalStationNumber)
        {
            return MXDriver.Connect(logicalStationNumber);
        }
        /// <summary>
        /// Ngắt kết nối với MX Component
        /// </summary>
        /// <returns>Return true nếu ngắt kết nối thành công</returns>
        public static bool Disconnect()
        {
            return MXDriver.Disconnect();
        }
        /// <summary>
        /// Kiểm tra kết nối
        /// </summary>
        /// <returns>Return true nếu đã kết nối, return false nếu ngắt kết nối</returns>
        public static bool IsConnected()
        {
            return MXDriver.IsConnected();
        }
        /// <summary>
        /// Set data cho PLC
        /// </summary>
        /// <param name="device">Địa chỉ trên PLC</param>
        /// <param name="data">Dữ liệu truyền xuống PLC</param>
        /// <returns>Return true nếu set thành công</returns>
        public static bool SetDevice(string device, short data)
        {
            return MXDriver.SetDevice(device, data);
        }
        /// <summary>
        /// Get data từ PLC
        /// </summary>
        /// <param name="device">Địa chỉ cần lấy data</param>
        /// <param name="data">Data trả về</param>
        /// <returns>Return true nếu lấy data thành công</returns>
        public static bool GetDevice(string device, out short data)
        {
            return MXDriver.GetDevice(device, out data);
        }
    }
}
