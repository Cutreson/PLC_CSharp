﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_ServoControl
{
    public partial class GUIConnection : Form
    {
        public GUIConnection()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogicalStationNumber.Text == "")
                {
                    MessageBox.Show("The TextBox has not been entered.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ConnectPLC.Connect(Convert.ToInt32(txtLogicalStationNumber.Text)))
                    {
                        MessageBox.Show("Connected", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtLogicalStationNumber.Text == "")
                {
                    MessageBox.Show("The TextBox has not been entered.", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ConnectPLC.Disconnect())
                    {
                        MessageBox.Show("Disconnected", "Connection");
                        this.Close();
                    }
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
