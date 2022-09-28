namespace _01_ServoControl
{
    partial class GUI
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCurrentSpeed = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCurrentPosition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOrg = new System.Windows.Forms.Button();
            this.cboPoint = new System.Windows.Forms.ComboBox();
            this.btnManualStart = new System.Windows.Forms.Button();
            this.cboAxis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnJogDown = new System.Windows.Forms.Button();
            this.btnJogUp = new System.Windows.Forms.Button();
            this.btnOffServo = new System.Windows.Forms.Button();
            this.btnOnServo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lampDelay3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.lampDelay2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lampPoint3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lampPoint2 = new System.Windows.Forms.Label();
            this.lampDelay1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtRunSpeed = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtDelay3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtPoint3 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtDelay2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPoint2 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtDelay1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtJogSpeed = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtPoint1 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.lampDelay3.SuspendLayout();
            this.lampDelay2.SuspendLayout();
            this.lampPoint3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.lampDelay1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.connectionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(784, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(58, 23);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(91, 23);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(42, 23);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(65, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(114, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(163, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(79, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "CONTROL";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnReturn);
            this.panelControl.Controls.Add(this.btnReset);
            this.panelControl.Controls.Add(this.btnStop);
            this.panelControl.Controls.Add(this.btnStart);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Location = new System.Drawing.Point(32, 32);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(248, 180);
            this.panelControl.TabIndex = 5;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(142, 134);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(80, 30);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(33, 134);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(142, 91);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(80, 30);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(33, 91);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 30);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCurrentSpeed);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCurrentPosition);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnOrg);
            this.panel1.Controls.Add(this.cboPoint);
            this.panel1.Controls.Add(this.btnManualStart);
            this.panel1.Controls.Add(this.cboAxis);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnJogDown);
            this.panel1.Controls.Add(this.btnJogUp);
            this.panel1.Controls.Add(this.btnOffServo);
            this.panel1.Controls.Add(this.btnOnServo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(32, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 334);
            this.panel1.TabIndex = 9;
            // 
            // txtCurrentSpeed
            // 
            this.txtCurrentSpeed.Location = new System.Drawing.Point(143, 286);
            this.txtCurrentSpeed.Name = "txtCurrentSpeed";
            this.txtCurrentSpeed.Size = new System.Drawing.Size(80, 23);
            this.txtCurrentSpeed.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(139, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Speed(mm/s)";
            // 
            // txtCurrentPosition
            // 
            this.txtCurrentPosition.Location = new System.Drawing.Point(33, 286);
            this.txtCurrentPosition.Name = "txtCurrentPosition";
            this.txtCurrentPosition.Size = new System.Drawing.Size(80, 23);
            this.txtCurrentPosition.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Position(mm)";
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(33, 176);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Size = new System.Drawing.Size(80, 30);
            this.btnOrg.TabIndex = 13;
            this.btnOrg.Text = "Origin";
            this.btnOrg.UseVisualStyleBackColor = true;
            // 
            // cboPoint
            // 
            this.cboPoint.FormattingEnabled = true;
            this.cboPoint.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboPoint.Location = new System.Drawing.Point(143, 225);
            this.cboPoint.Name = "cboPoint";
            this.cboPoint.Size = new System.Drawing.Size(80, 24);
            this.cboPoint.TabIndex = 12;
            // 
            // btnManualStart
            // 
            this.btnManualStart.Location = new System.Drawing.Point(33, 221);
            this.btnManualStart.Name = "btnManualStart";
            this.btnManualStart.Size = new System.Drawing.Size(80, 30);
            this.btnManualStart.TabIndex = 11;
            this.btnManualStart.Text = "MA Start";
            this.btnManualStart.UseVisualStyleBackColor = true;
            // 
            // cboAxis
            // 
            this.cboAxis.FormattingEnabled = true;
            this.cboAxis.Items.AddRange(new object[] {
            "X1",
            "X2",
            "X3",
            "Y1",
            "Y2",
            "Y3",
            "Z1",
            "Z2",
            "Z3"});
            this.cboAxis.Location = new System.Drawing.Point(143, 51);
            this.cboAxis.Name = "cboAxis";
            this.cboAxis.Size = new System.Drawing.Size(80, 24);
            this.cboAxis.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Axis";
            // 
            // btnJogDown
            // 
            this.btnJogDown.Location = new System.Drawing.Point(143, 131);
            this.btnJogDown.Name = "btnJogDown";
            this.btnJogDown.Size = new System.Drawing.Size(80, 30);
            this.btnJogDown.TabIndex = 8;
            this.btnJogDown.Text = "Jog -";
            this.btnJogDown.UseVisualStyleBackColor = true;
            this.btnJogDown.Click += new System.EventHandler(this.btnJogDown_Click);
            // 
            // btnJogUp
            // 
            this.btnJogUp.Location = new System.Drawing.Point(33, 131);
            this.btnJogUp.Name = "btnJogUp";
            this.btnJogUp.Size = new System.Drawing.Size(80, 30);
            this.btnJogUp.TabIndex = 7;
            this.btnJogUp.Text = "Jog +";
            this.btnJogUp.UseVisualStyleBackColor = true;
            this.btnJogUp.Click += new System.EventHandler(this.btnJogUp_Click);
                 // btnOffServo
            // 
            this.btnOffServo.Location = new System.Drawing.Point(143, 86);
            this.btnOffServo.Name = "btnOffServo";
            this.btnOffServo.Size = new System.Drawing.Size(80, 30);
            this.btnOffServo.TabIndex = 6;
            this.btnOffServo.Text = "Off Servo";
            this.btnOffServo.UseVisualStyleBackColor = true;
            // 
            // btnOnServo
            // 
            this.btnOnServo.Location = new System.Drawing.Point(33, 86);
            this.btnOnServo.Name = "btnOnServo";
            this.btnOnServo.Size = new System.Drawing.Size(80, 30);
            this.btnOnServo.TabIndex = 5;
            this.btnOnServo.Text = "On Servo";
            this.btnOnServo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "MANUAL";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.lampDelay3);
            this.panel2.Controls.Add(this.lampDelay2);
            this.panel2.Controls.Add(this.lampPoint3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.lampDelay1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(311, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(190, 540);
            this.panel2.TabIndex = 18;
            // 
            // lampDelay3
            // 
            this.lampDelay3.AccessibleDescription = "lampPoint1";
            this.lampDelay3.BackColor = System.Drawing.Color.DarkGray;
            this.lampDelay3.Controls.Add(this.label14);
            this.lampDelay3.Location = new System.Drawing.Point(52, 461);
            this.lampDelay3.Name = "lampDelay3";
            this.lampDelay3.Size = new System.Drawing.Size(80, 30);
            this.lampDelay3.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Delay 3";
            // 
            // lampDelay2
            // 
            this.lampDelay2.AccessibleDescription = "lampPoint1";
            this.lampDelay2.BackColor = System.Drawing.Color.DarkGray;
            this.lampDelay2.Controls.Add(this.label11);
            this.lampDelay2.Location = new System.Drawing.Point(52, 313);
            this.lampDelay2.Name = "lampDelay2";
            this.lampDelay2.Size = new System.Drawing.Size(80, 30);
            this.lampDelay2.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Delay 2";
            // 
            // lampPoint3
            // 
            this.lampPoint3.AccessibleDescription = "lampPoint1";
            this.lampPoint3.BackColor = System.Drawing.Color.DarkGray;
            this.lampPoint3.Controls.Add(this.label15);
            this.lampPoint3.Location = new System.Drawing.Point(52, 387);
            this.lampPoint3.Name = "lampPoint3";
            this.lampPoint3.Size = new System.Drawing.Size(80, 30);
            this.lampPoint3.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(17, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Point 3";
            // 
            // panel5
            // 
            this.panel5.AccessibleDescription = "lampPoint1";
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.lampPoint2);
            this.panel5.Location = new System.Drawing.Point(52, 239);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 30);
            this.panel5.TabIndex = 7;
            // 
            // lampPoint2
            // 
            this.lampPoint2.AutoSize = true;
            this.lampPoint2.Location = new System.Drawing.Point(17, 6);
            this.lampPoint2.Name = "lampPoint2";
            this.lampPoint2.Size = new System.Drawing.Size(52, 17);
            this.lampPoint2.TabIndex = 0;
            this.lampPoint2.Text = "Point 2";
            // 
            // lampDelay1
            // 
            this.lampDelay1.AccessibleDescription = "lampPoint1";
            this.lampDelay1.BackColor = System.Drawing.Color.DarkGray;
            this.lampDelay1.Controls.Add(this.label10);
            this.lampDelay1.Location = new System.Drawing.Point(52, 165);
            this.lampDelay1.Name = "lampDelay1";
            this.lampDelay1.Size = new System.Drawing.Size(80, 30);
            this.lampDelay1.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Delay 1";
            // 
            // panel3
            // 
            this.panel3.AccessibleDescription = "lampPoint1";
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(52, 91);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 30);
            this.panel3.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Point 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(54, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "AUTO";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.txtRunSpeed);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Controls.Add(this.txtDelay3);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.txtPoint3);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtDelay2);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtPoint2);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Controls.Add(this.txtDelay1);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.txtJogSpeed);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtPoint1);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(515, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 501);
            this.panel4.TabIndex = 18;
            // 
            // txtRunSpeed
            // 
            this.txtRunSpeed.Location = new System.Drawing.Point(144, 172);
            this.txtRunSpeed.Name = "txtRunSpeed";
            this.txtRunSpeed.Size = new System.Drawing.Size(80, 23);
            this.txtRunSpeed.TabIndex = 33;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(140, 152);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 17);
            this.label23.TabIndex = 32;
            this.label23.Text = "Run Speed";
            // 
            // txtDelay3
            // 
            this.txtDelay3.Location = new System.Drawing.Point(31, 468);
            this.txtDelay3.Name = "txtDelay3";
            this.txtDelay3.Size = new System.Drawing.Size(80, 23);
            this.txtDelay3.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(31, 448);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(15, 17);
            this.label21.TabIndex = 30;
            this.label21.Text = "s";
            // 
            // txtPoint3
            // 
            this.txtPoint3.Location = new System.Drawing.Point(31, 394);
            this.txtPoint3.Name = "txtPoint3";
            this.txtPoint3.Size = new System.Drawing.Size(80, 23);
            this.txtPoint3.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(31, 374);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(30, 17);
            this.label22.TabIndex = 28;
            this.label22.Text = "mm";
            // 
            // txtDelay2
            // 
            this.txtDelay2.Location = new System.Drawing.Point(31, 320);
            this.txtDelay2.Name = "txtDelay2";
            this.txtDelay2.Size = new System.Drawing.Size(80, 23);
            this.txtDelay2.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 300);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 17);
            this.label16.TabIndex = 26;
            this.label16.Text = "s";
            // 
            // txtPoint2
            // 
            this.txtPoint2.Location = new System.Drawing.Point(31, 246);
            this.txtPoint2.Name = "txtPoint2";
            this.txtPoint2.Size = new System.Drawing.Size(80, 23);
            this.txtPoint2.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(31, 226);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(30, 17);
            this.label20.TabIndex = 24;
            this.label20.Text = "mm";
            // 
            // txtDelay1
            // 
            this.txtDelay1.Location = new System.Drawing.Point(31, 172);
            this.txtDelay1.Name = "txtDelay1";
            this.txtDelay1.Size = new System.Drawing.Size(80, 23);
            this.txtDelay1.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "s";
            // 
            // txtJogSpeed
            // 
            this.txtJogSpeed.Location = new System.Drawing.Point(143, 97);
            this.txtJogSpeed.Name = "txtJogSpeed";
            this.txtJogSpeed.Size = new System.Drawing.Size(80, 23);
            this.txtJogSpeed.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(139, 77);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 17);
            this.label17.TabIndex = 20;
            this.label17.Text = "Jog Speed";
            // 
            // txtPoint1
            // 
            this.txtPoint1.Location = new System.Drawing.Point(31, 98);
            this.txtPoint1.Name = "txtPoint1";
            this.txtPoint1.Size = new System.Drawing.Size(80, 23);
            this.txtPoint1.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "mm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(76, 42);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 24);
            this.label18.TabIndex = 4;
            this.label18.Text = "SETTING";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module Servo";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.lampDelay3.ResumeLayout(false);
            this.lampDelay3.PerformLayout();
            this.lampDelay2.ResumeLayout(false);
            this.lampDelay2.PerformLayout();
            this.lampPoint3.ResumeLayout(false);
            this.lampPoint3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.lampDelay1.ResumeLayout(false);
            this.lampDelay1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCurrentSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCurrentPosition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.ComboBox cboPoint;
        private System.Windows.Forms.Button btnManualStart;
        private System.Windows.Forms.ComboBox cboAxis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnJogDown;
        private System.Windows.Forms.Button btnJogUp;
        private System.Windows.Forms.Button btnOffServo;
        private System.Windows.Forms.Button btnOnServo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel lampDelay3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel lampDelay2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel lampPoint3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lampPoint2;
        private System.Windows.Forms.Panel lampDelay1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRunSpeed;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtDelay3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtPoint3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtDelay2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPoint2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtDelay1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtJogSpeed;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtPoint1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
    }
}