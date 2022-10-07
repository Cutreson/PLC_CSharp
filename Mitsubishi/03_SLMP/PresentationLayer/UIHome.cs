using SlmpProtocol;
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

namespace _03_SLMP.PresentationLayer
{
    public partial class UIHome : Form
    {
        private SlmpClient client;
        private Thread threadCheckStatus;
        public UIHome()
        {
            InitializeComponent();
        }

        private void UIHome_Load(object sender, EventArgs e)
        {
            SlmpConfig cfg = new SlmpConfig("0.0.0.0", 2000)
            {
                ConnTimeout = 1000,
                RecvTimeout = 1000,
                SendTimeout = 1000,
            };
            client = new SlmpClient(cfg);

            txtIPAddress.Text = "192.168.0.10";
            txtPort.Text = "2000";

            Control.CheckForIllegalCrossThreadCalls = false;
            threadCheckStatus = new Thread(checkStatus);
            threadCheckStatus.IsBackground = true;
            threadCheckStatus.Start();

        }
        public void checkStatus()
        {
            while (true)
            {
                if (client.IsConnected())
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
        //private void WriteData()
        //{
        //    while (true)
        //    {
        //        if (runStatus)
        //        {
        //            try
        //            {
        //                int D1 = new Random().Next(0, 10000);
        //                txtD1.Text = D1.ToString();
        //                client.WriteWordDevice("D1", (ushort)D1);
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.ToString());
        //            }

        //        }
        //        Thread.Sleep(10);
        //    }
        //}
        //private void ReadData()
        //{
        //    while (true)
        //    {
        //        if (runStatus)
        //        {
        //            try
        //            {
        //                txtD11.Text = client.ReadWordDevice("D11").ToString();
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.ToString());
        //            }
        //        }
        //        Thread.Sleep(10);
        //    }
        //}
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SlmpConfig cfg = new SlmpConfig(txtIPAddress.Text, Convert.ToInt32(txtPort.Text))
                {
                    ConnTimeout = 1000,
                    RecvTimeout = 1000,
                    SendTimeout = 1000,
                };
                client = new SlmpClient(cfg);
                client.Connect();
                if (client.IsConnected())
                {
                    MessageBox.Show("Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if(client.IsConnected())
                {
                    client.Disconnect();
                    if (!client.IsConnected())
                    {
                        MessageBox.Show("Disconnected", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbM1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    client.WriteBitDevice("M1", cbM1.Checked);
                    txtY1.Text = client.ReadBitDevice("Y1").ToString();
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cbM2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    client.WriteBitDevice("M2", cbM2.Checked);
                    txtY2.Text = client.ReadBitDevice("Y2").ToString();
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbM3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    client.WriteBitDevice("M3", cbM3.Checked);
                    txtY3.Text = client.ReadBitDevice("Y3").ToString();
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbM4_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    client.WriteBitDevice("M4", cbM4.Checked);
                    txtY4.Text = client.ReadBitDevice("Y4").ToString();
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbM5_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    client.WriteBitDevice("M5", cbM5.Checked);
                    txtY5.Text = client.ReadBitDevice("Y5").ToString();         
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    txtValue.Text = client.ReadWordDevice(txtAddress.Text).ToString();
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (client.IsConnected())
                {
                    client.WriteWordDevice(txtAddress.Text, ushort.Parse(txtValue.Text));
                }
                else
                {
                    MessageBox.Show("Not Connected", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
