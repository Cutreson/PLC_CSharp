namespace _03_SLMP.PresentationLayer
{
    partial class UIHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtIPAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWrite = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtY5 = new System.Windows.Forms.TextBox();
            this.cbM5 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtY4 = new System.Windows.Forms.TextBox();
            this.cbM4 = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtY3 = new System.Windows.Forms.TextBox();
            this.cbM3 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtY2 = new System.Windows.Forms.TextBox();
            this.cbM2 = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtY1 = new System.Windows.Forms.TextBox();
            this.cbM1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.txtIPAddress);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.lbStatus);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Location = new System.Drawing.Point(36, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 326);
            this.panel1.TabIndex = 97;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(211, 164);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(120, 23);
            this.txtPort.TabIndex = 37;
            // 
            // txtIPAddress
            // 
            this.txtIPAddress.Location = new System.Drawing.Point(211, 134);
            this.txtIPAddress.Name = "txtIPAddress";
            this.txtIPAddress.Size = new System.Drawing.Size(120, 23);
            this.txtIPAddress.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(73, 69);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(255, 20);
            this.label20.TabIndex = 35;
            this.label20.Text = "SLMP Communication Protocol";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(211, 208);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(120, 30);
            this.btnDisconnect.TabIndex = 34;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(73, 208);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 30);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(73, 167);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 17);
            this.label23.TabIndex = 32;
            this.label23.Text = "Port";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(73, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(76, 17);
            this.label24.TabIndex = 31;
            this.label24.Text = "IP Address";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbStatus.Location = new System.Drawing.Point(211, 107);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(115, 17);
            this.lbStatus.TabIndex = 30;
            this.lbStatus.Text = "Not Connected";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(73, 107);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 17);
            this.label25.TabIndex = 29;
            this.label25.Text = "Status :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnWrite);
            this.panel2.Controls.Add(this.txtValue);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.btnRead);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtY5);
            this.panel2.Controls.Add(this.cbM5);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtY4);
            this.panel2.Controls.Add(this.cbM4);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.txtY3);
            this.panel2.Controls.Add(this.cbM3);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtY2);
            this.panel2.Controls.Add(this.cbM2);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtY1);
            this.panel2.Controls.Add(this.cbM1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(456, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 326);
            this.panel2.TabIndex = 98;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(512, 258);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(100, 23);
            this.btnWrite.TabIndex = 94;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(368, 258);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 23);
            this.txtValue.TabIndex = 93;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(228, 261);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(119, 17);
            this.label22.TabIndex = 92;
            this.label22.Text = "Read/Write Value";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(512, 221);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 23);
            this.btnRead.TabIndex = 91;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(368, 221);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 90;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(228, 224);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(114, 17);
            this.label21.TabIndex = 89;
            this.label21.Text = "Modbus Address";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(652, 139);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 17);
            this.label18.TabIndex = 87;
            this.label18.Text = "Y5";
            // 
            // txtY5
            // 
            this.txtY5.Location = new System.Drawing.Point(652, 159);
            this.txtY5.Name = "txtY5";
            this.txtY5.Size = new System.Drawing.Size(100, 23);
            this.txtY5.TabIndex = 86;
            // 
            // cbM5
            // 
            this.cbM5.AutoSize = true;
            this.cbM5.Location = new System.Drawing.Point(652, 99);
            this.cbM5.Name = "cbM5";
            this.cbM5.Size = new System.Drawing.Size(46, 21);
            this.cbM5.TabIndex = 85;
            this.cbM5.Text = "M5";
            this.cbM5.UseVisualStyleBackColor = true;
            this.cbM5.CheckedChanged += new System.EventHandler(this.cbM5_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(510, 139);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 17);
            this.label17.TabIndex = 84;
            this.label17.Text = "Y4";
            // 
            // txtY4
            // 
            this.txtY4.Location = new System.Drawing.Point(510, 159);
            this.txtY4.Name = "txtY4";
            this.txtY4.Size = new System.Drawing.Size(100, 23);
            this.txtY4.TabIndex = 83;
            // 
            // cbM4
            // 
            this.cbM4.AutoSize = true;
            this.cbM4.Location = new System.Drawing.Point(510, 99);
            this.cbM4.Name = "cbM4";
            this.cbM4.Size = new System.Drawing.Size(46, 21);
            this.cbM4.TabIndex = 82;
            this.cbM4.Text = "M4";
            this.cbM4.UseVisualStyleBackColor = true;
            this.cbM4.CheckedChanged += new System.EventHandler(this.cbM4_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(368, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 81;
            this.label16.Text = "Y3";
            // 
            // txtY3
            // 
            this.txtY3.Location = new System.Drawing.Point(368, 159);
            this.txtY3.Name = "txtY3";
            this.txtY3.Size = new System.Drawing.Size(100, 23);
            this.txtY3.TabIndex = 80;
            // 
            // cbM3
            // 
            this.cbM3.AutoSize = true;
            this.cbM3.Location = new System.Drawing.Point(368, 99);
            this.cbM3.Name = "cbM3";
            this.cbM3.Size = new System.Drawing.Size(46, 21);
            this.cbM3.TabIndex = 79;
            this.cbM3.Text = "M3";
            this.cbM3.UseVisualStyleBackColor = true;
            this.cbM3.CheckedChanged += new System.EventHandler(this.cbM3_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(231, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 78;
            this.label15.Text = "Y2";
            // 
            // txtY2
            // 
            this.txtY2.Location = new System.Drawing.Point(231, 159);
            this.txtY2.Name = "txtY2";
            this.txtY2.Size = new System.Drawing.Size(100, 23);
            this.txtY2.TabIndex = 77;
            // 
            // cbM2
            // 
            this.cbM2.AutoSize = true;
            this.cbM2.Location = new System.Drawing.Point(231, 99);
            this.cbM2.Name = "cbM2";
            this.cbM2.Size = new System.Drawing.Size(46, 21);
            this.cbM2.TabIndex = 76;
            this.cbM2.Text = "M2";
            this.cbM2.UseVisualStyleBackColor = true;
            this.cbM2.CheckedChanged += new System.EventHandler(this.cbM2_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 17);
            this.label14.TabIndex = 75;
            this.label14.Text = "Y1";
            // 
            // txtY1
            // 
            this.txtY1.Location = new System.Drawing.Point(80, 159);
            this.txtY1.Name = "txtY1";
            this.txtY1.Size = new System.Drawing.Size(100, 23);
            this.txtY1.TabIndex = 74;
            // 
            // cbM1
            // 
            this.cbM1.AutoSize = true;
            this.cbM1.Location = new System.Drawing.Point(80, 99);
            this.cbM1.Name = "cbM1";
            this.cbM1.Size = new System.Drawing.Size(46, 21);
            this.cbM1.TabIndex = 73;
            this.cbM1.Text = "M1";
            this.cbM1.UseVisualStyleBackColor = true;
            this.cbM1.CheckedChanged += new System.EventHandler(this.cbM1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(63, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 55;
            this.label1.Text = "Manual";
            // 
            // UIHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 752);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UIHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UIHome";
            this.Load += new System.EventHandler(this.UIHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtIPAddress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtY5;
        private System.Windows.Forms.CheckBox cbM5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtY4;
        private System.Windows.Forms.CheckBox cbM4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtY3;
        private System.Windows.Forms.CheckBox cbM3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtY2;
        private System.Windows.Forms.CheckBox cbM2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtY1;
        private System.Windows.Forms.CheckBox cbM1;
        private System.Windows.Forms.Label label1;
    }
}