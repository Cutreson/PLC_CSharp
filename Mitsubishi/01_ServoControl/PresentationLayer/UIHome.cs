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
using _01_ServoControl.BusinessLogicLayer;
using ActUtlTypeLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01_ServoControl
{
    public partial class UIHome : Form
    {
        private bool isConnected;
        public UIHome()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            txtAccTime.Text = "0";
            txtSpeed.Text = "0";
            txtJogStep.Text = "0";
            txtCommand.Text = "0";

            Thread Thr_CheckConnect = new Thread(CheckConnect);
            Thr_CheckConnect.IsBackground = true;
            Thr_CheckConnect.Start();
            Thread Thr_ReadData = new Thread(ReadData);
            Thr_ReadData.IsBackground = true;
            Thr_ReadData.Start();
            Thread Thr_WriteData = new Thread(WriteData);
            Thr_WriteData.IsBackground = true;
            Thr_WriteData.Start();

        }

        private void CheckConnect()
        {
            while(true)
            {
                try
                {
                    short data;
                    PLCConnector.GetDevice("M8000", out data);
                    if(data == 1)
                    {
                        isConnected = true;
                        lbConnectionStatus.Text = "Connected";
                    }
                    else
                    {
                        isConnected = false;
                        lbConnectionStatus.Text = "Not Connected";
                    }
                }
                catch(Exception ex)
                {
                    isConnected = false;
                    lbConnectionStatus.Text = "Not Connected";
                }
                Thread.Sleep(1000);
            }
        }
        private void ReadData()
        {
            while(true)
            {
                try
                {
                   if(isConnected)
                    {
                        UpdateLampColor("M53", lbLampServoStatus);
                        UpdateLampColor("M65", lbLampLimitDown);
                        UpdateLampColor("M64", lbLampHome);
                        UpdateLampColor("M66", lbLampLimitUp);
                        UpdateButtonColor("M10", btnManual);
                        UpdateButtonColor("M50", btnAxis1);
                        UpdateButtonColor("M51", btnAxis2);
                        UpdateButtonColor("M52", btnAxis3);
                        UpdateButtonColor("M33", btnJogDown);
                        UpdateButtonColor("M32", btnJogUp);
                        UpdateButtonColor("M35", btnLimitDown);
                        UpdateButtonColor("M34", btnHome);
                        UpdateButtonColor("M36", btnLimitUp);
                        UpdateButtonColor("M30", btnRun);
                        UpdateButtonColor("M31", btnStop);
                        UpdateTextBoxValue("D12", txtCurrentPosition);
                        UpdateButtonColor("M12", btnAuto);
                        UpdateButtonColor("M13", btnTrigger);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Thread.Sleep(10);
            }
        }
        private void WriteData()
        {
            while (true)
            {
                try
                {
                    if (isConnected)
                    {
                        PLCConnector.SetDevice("D104", short.Parse(txtAccTime.Text));
                        PLCConnector.SetDevice("D102", short.Parse(txtSpeed.Text));
                        PLCConnector.SetDevice("D106", short.Parse(txtJogStep.Text));
                        PLCConnector.SetDevice("D18", short.Parse(txtCommand.Text));

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Thread.Sleep(100);
            }
        }
        private void UpdateLampColor(string device, Label lamp)
        {
            short readData;
            PLCConnector.GetDevice(device, out readData);
            if(readData == 1)
            {
                lamp.BackColor = Color.Green;
            }
            else
            {
                lamp.BackColor = Color.Red;
            }
        }
        private void UpdateButtonColor(string device, System.Windows.Forms.Button button)
        {
            short readData;
            PLCConnector.GetDevice(device, out readData);
            if (readData == 1)
            {
                button.BackColor = Color.Blue;
            }
            else
            {
                button.BackColor = Color.LightGray;
            }
        }
        private void UpdateTextBoxValue(string device, System.Windows.Forms.TextBox textBox)
        {
            short readData;
            PLCConnector.GetDevice(device, out readData);
            textBox.Text = readData.ToString();
        }
        //Nhấn vào StripMenu Connection, mở UI Connection
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UIConnection gui = new UIConnection();
            gui.Show();
        }
        //Jog+
        private void btnJogUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M45", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M45", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }     
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        //Jog-
        private void btnJogDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M44", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M44", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M1", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M1", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAxis1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M40", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M40", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAxis2_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M41", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M41", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAxis3_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M42", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M42", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnJogDown_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M23", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M23", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnJogUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M22", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M22", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLimitDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M25", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M25", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M24", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M24", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnLimitUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M26", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M26", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine(short.Parse(txtCommand.Text));
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M20", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M20", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M21", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M21", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M2", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M2", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnTrigger_Click(object sender, EventArgs e)
        {
            try
            {
                if (PLCConnector.IsConnected())
                {
                    PLCConnector.SetDevice("M3", 1);
                    Thread.Sleep(10);
                    PLCConnector.SetDevice("M3", 0);
                }
                else
                {
                    MessageBox.Show("Check connection", Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
