using _02_Modbus.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Modbus.PresentationLayer
{
    public partial class UIHome : Form
    {
        private Thread ThreadWriteData;
        private Thread ThreadReadData;
        private bool runStatus;
        public UIHome()
        {
            InitializeComponent();
        }

        private void UIHome_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            ThreadWriteData = new Thread(WriteData);
            ThreadWriteData.IsBackground = true;
            ThreadWriteData.Start();
            ThreadReadData = new Thread(ReadData);
            ThreadReadData.IsBackground = true;
            ThreadReadData.Start();

        }
        private void WriteData()
        {
            while(true)
            {
                if(runStatus)
                {
                    int D1 = new Random().Next(0, 10000);
                    ModbusDriver.WriteSingleRegister(1, D1);
                    txtD1.Text = D1.ToString();
                    Thread.Sleep(10);
                    int D2 = new Random().Next(0, 10000);
                    ModbusDriver.WriteSingleRegister(2, D2);
                    txtD2.Text = D2.ToString();
                    Thread.Sleep(10);
                    int D3 = new Random().Next(0, 10000);
                    ModbusDriver.WriteSingleRegister(3, D3);
                    txtD3.Text = D3.ToString();
                    Thread.Sleep(10);
                    int D4 = new Random().Next(0, 10000);
                    ModbusDriver.WriteSingleRegister(4, D4);
                    txtD4.Text = D4.ToString();
                    Thread.Sleep(10);
                    int D5 = new Random().Next(0, 10000);
                    ModbusDriver.WriteSingleRegister(5, D5);
                    txtD5.Text = D5.ToString();
                }
                Thread.Sleep(1000);
            }
        }
        private void ReadData()
        {
            while (true)
            {
                if (runStatus)
                {
                    int D11;
                    ModbusDriver.ReadHoldingRegister(11, out D11);
                    txtD11.Text = D11.ToString();
                    Thread.Sleep(10);
                    int D12;
                    ModbusDriver.ReadHoldingRegister(12, out D12);
                    txtD12.Text = D12.ToString();
                    Thread.Sleep(10);
                    int D13;
                    ModbusDriver.ReadHoldingRegister(13, out D13);
                    txtD13.Text = D13.ToString();
                    Thread.Sleep(10);
                    int D14;
                    ModbusDriver.ReadHoldingRegister(14, out D14);
                    txtD14.Text = D14.ToString();
                    Thread.Sleep(10);
                    int D15;
                    ModbusDriver.ReadHoldingRegister(15, out D15);
                    txtD15.Text = D15.ToString();
                }
                Thread.Sleep(1000);
            }
        }
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIConnection uIConnection = new UIConnection();
            uIConnection.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbM1_CheckedChanged(object sender, EventArgs e)
        {
            ModbusDriver.WriteSingleCoil(8193, cbM1.Checked);
            bool coilRead;
            ModbusDriver.ReadSingleCoil(1, out coilRead);
            txtY1.Text = coilRead.ToString();
        }

        private void cbM2_CheckedChanged(object sender, EventArgs e)
        {
            ModbusDriver.WriteSingleCoil(8194, cbM2.Checked);
            bool coilRead;
            ModbusDriver.ReadSingleCoil(2, out coilRead);
            txtY2.Text = coilRead.ToString();
        }

        private void cbM3_CheckedChanged(object sender, EventArgs e)
        {
            ModbusDriver.WriteSingleCoil(8195, cbM3.Checked);
            bool coilRead;
            ModbusDriver.ReadSingleCoil(3, out coilRead);
            txtY3.Text = coilRead.ToString();
        }

        private void cbM4_CheckedChanged(object sender, EventArgs e)
        {
            ModbusDriver.WriteSingleCoil(8196, cbM4.Checked);
            bool coilRead;
            ModbusDriver.ReadSingleCoil(4, out coilRead);
            txtY4.Text = coilRead.ToString();
        }

        private void cbM5_CheckedChanged(object sender, EventArgs e)
        {
            ModbusDriver.WriteSingleCoil(8197, cbM5.Checked);
            bool coilRead;
            ModbusDriver.ReadSingleCoil(5, out coilRead);
            txtY5.Text = coilRead.ToString();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            ModbusDriver.WriteSingleRegister(Convert.ToInt32(txtModbusAddress.Text), Convert.ToInt32(txtValue.Text));
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int dataRead;
            ModbusDriver.ReadHoldingRegister(Convert.ToInt32(txtModbusAddress.Text), out dataRead);
            txtValue.Text = dataRead.ToString();    
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            runStatus = true;        
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            runStatus = false;
        }
    }
}
