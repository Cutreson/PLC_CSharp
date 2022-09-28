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
using ActUtlTypeLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _01_ServoControl
{
    public partial class GUI : Form
    {
        private ActUtlType plc;
        public GUI()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void GUI_Load(object sender, EventArgs e)
        {
            plc = new ActUtlType();
            Thread thrd = new Thread(Demo);
            thrd.IsBackground = true;
            thrd.Start();
        }
        void Demo()
        {
            while(true)
            {
                try
                {
                    int readData;
                    ConnectPLC.plc.GetDevice("D12", out readData);
                    txtCurrentPosition.Text = readData.ToString();      
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Thread.Sleep(100);
            }
        }
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUIConnection gui = new GUIConnection();
            gui.Show();
        }

        private void btnJogUp_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectPLC.plc.SetDevice("M44", 1);
                Thread.Sleep(10);
                ConnectPLC.plc.SetDevice("M44", 0);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnJogDown_Click(object sender, EventArgs e)
        {
            try
            {
                ConnectPLC.plc.SetDevice("M45", 1);
                Thread.Sleep(10);
                ConnectPLC.plc.SetDevice("M45", 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Manual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

    }
}
