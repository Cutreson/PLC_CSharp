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
        public UIHome()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            Thread updateData = new Thread(UpdateData);
            updateData.IsBackground = true;
            updateData.Start();
        }
        /// <summary>
        /// Thread liên tục lấy dữ liệu từ PLC truyền lên UI, các thông số như Position, Speed...
        /// </summary>
        void UpdateData()
        {
            while(true)
            {
                try
                {
                   if(PLCConnector.IsConnected())
                    {
                        int readData;
                        PLCConnector.GetDevice("D12", out readData);
                        txtCurrentPosition.Text = readData.ToString();
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

    }
}
