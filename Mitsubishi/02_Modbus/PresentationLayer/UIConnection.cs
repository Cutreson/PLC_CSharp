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
    public partial class UIConnection : Form
    {
        private Thread threadCheckStatus;
        public UIConnection()
        {
            InitializeComponent();

        }

        private void UIConnection_Load(object sender, EventArgs e)
        {
            txtIPAddress.Text = "192.168.0.10";
            txtPort.Text = "502";
            Control.CheckForIllegalCrossThreadCalls = false;
            threadCheckStatus = new Thread(checkStatus);
            threadCheckStatus.IsBackground = true;
            threadCheckStatus.Start();
        }

        public void checkStatus()
        {
            while (true)
            {
                if (ModbusDriver.IsConnected())
                {
                    lbStatus.Text = "Connected";
                    txtIPAddress.ReadOnly = true;
                    txtPort.ReadOnly = true;
                }
                else
                {
                    lbStatus.Text = "Not Connected";
                    txtIPAddress.ReadOnly = false;
                    txtPort.ReadOnly = false;
                }
                Thread.Sleep(1000);
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIPAddress.Text == "")
                {
                    MessageBox.Show("The TextBox has not been entered.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ModbusDriver.Connect(txtIPAddress.Text, Convert.ToInt32(txtPort.Text)))
                    {
                        MessageBox.Show("Connected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        threadCheckStatus.Abort();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        { 
            try
            {
                if (txtIPAddress.Text == "")
                {
                    MessageBox.Show("The TextBox has not been entered.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ModbusDriver.Disconnect();
                    MessageBox.Show("Disconnected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    threadCheckStatus.Abort();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
