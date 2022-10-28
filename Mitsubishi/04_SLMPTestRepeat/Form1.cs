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

namespace _04_SLMPTestRepeat
{
    
    public partial class Form1 : Form
    {
        private SlmpClient m_Client;
        private Thread m_ThreadRead;
        private Thread m_ThreadWrite;
        private bool m_bConnected;
        private bool m_bWriting;
        private bool m_bReading;
        private bool m_bRunRead;
        private bool m_bRunWrite;
        private ushort m_nCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtIPAddress.Text = "192.168.0.10";
            txtPort.Text = "2000";
            Control.CheckForIllegalCrossThreadCalls = false;
            m_ThreadRead = new Thread(new ThreadStart(RunThreadRead));
            m_ThreadRead.IsBackground = true;
            m_ThreadRead.Start();
            m_ThreadWrite = new Thread(new ThreadStart(RunThreadWrite));
            m_ThreadWrite.IsBackground = true;
            m_ThreadWrite.Start();
            SlmpConfig cfg = new SlmpConfig(txtIPAddress.Text, Convert.ToInt32(txtPort.Text))
            {
                ConnTimeout = 1000,
                RecvTimeout = 1000,
                SendTimeout = 1000,
            };
            m_Client = new SlmpClient(cfg);
        }
        public void RunThreadRead()
        {
            m_bRunRead = true;
            while(m_bRunRead)
            {
                Thread.Sleep(100);  
                if(m_bConnected && !m_bWriting)
                {
                    m_bReading = true;
                    try
                    {
                        lbDataRead.Text = m_Client.ReadWordDevice("D2").ToString();
                        m_bReading = false;
                    }
                    catch
                    {
                        m_bReading = false;
                    }
                }
            }
        }
        public void RunThreadWrite()
        {
            m_bRunWrite = true;
            while (m_bRunWrite)
            {
                Thread.Sleep(100);              
                if (m_bConnected && !m_bReading)
                {
                    m_bWriting = true;
                    m_nCount += 1;
                    if (m_nCount == 30000) m_nCount = 0;
                    try
                    {
                        m_Client.WriteWordDevice("D1", m_nCount);
                        lbDataWrite.Text = m_nCount.ToString();
                        m_bWriting = false;
                    }
                    catch
                    {
                        m_bWriting = false;
                    }
                }
            }
        }

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
                m_Client = new SlmpClient(cfg);
                m_Client.Connect();
                m_bConnected = true;
                Console.WriteLine(m_bConnected);
                if (m_Client.IsConnected())
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
                m_Client.Disconnect();
                m_bConnected = false;
                if (!m_Client.IsConnected())
                {
                    MessageBox.Show("Disconnected", Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
