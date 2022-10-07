namespace _01_ServoControl
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.lbConnectionStatus = new System.Windows.Forms.Label();
            this.btnAxis3 = new System.Windows.Forms.Button();
            this.btnAxis2 = new System.Windows.Forms.Button();
            this.btnAxis1 = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnLimitUp = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLimitDown = new System.Windows.Forms.Button();
            this.txtCurrentPosition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnJogUp = new System.Windows.Forms.Button();
            this.btnJogDown = new System.Windows.Forms.Button();
            this.txtJogStep = new System.Windows.Forms.TextBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.labksfnns = new System.Windows.Forms.Label();
            this.lbLampLimitUp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAccTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbLampHome = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbLampLimitDown = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbLampServoStatus = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.panelControl.SuspendLayout();
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(130, 72);
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
            this.label2.Location = new System.Drawing.Point(258, 72);
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
            this.label3.Location = new System.Drawing.Point(193, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "   ";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.label4);
            this.panelControl.Controls.Add(this.btnTrigger);
            this.panelControl.Controls.Add(this.btnAuto);
            this.panelControl.Controls.Add(this.lbConnectionStatus);
            this.panelControl.Controls.Add(this.btnAxis3);
            this.panelControl.Controls.Add(this.btnAxis2);
            this.panelControl.Controls.Add(this.btnAxis1);
            this.panelControl.Controls.Add(this.btnManual);
            this.panelControl.Controls.Add(this.btnStop);
            this.panelControl.Controls.Add(this.btnRun);
            this.panelControl.Controls.Add(this.txtCommand);
            this.panelControl.Controls.Add(this.label16);
            this.panelControl.Controls.Add(this.btnLimitUp);
            this.panelControl.Controls.Add(this.btnHome);
            this.panelControl.Controls.Add(this.btnLimitDown);
            this.panelControl.Controls.Add(this.txtCurrentPosition);
            this.panelControl.Controls.Add(this.label8);
            this.panelControl.Controls.Add(this.btnJogUp);
            this.panelControl.Controls.Add(this.btnJogDown);
            this.panelControl.Controls.Add(this.txtJogStep);
            this.panelControl.Controls.Add(this.txtSpeed);
            this.panelControl.Controls.Add(this.labksfnns);
            this.panelControl.Controls.Add(this.lbLampLimitUp);
            this.panelControl.Controls.Add(this.label15);
            this.panelControl.Controls.Add(this.txtAccTime);
            this.panelControl.Controls.Add(this.label7);
            this.panelControl.Controls.Add(this.lbLampHome);
            this.panelControl.Controls.Add(this.label13);
            this.panelControl.Controls.Add(this.lbLampLimitDown);
            this.panelControl.Controls.Add(this.label10);
            this.panelControl.Controls.Add(this.label9);
            this.panelControl.Controls.Add(this.lbLampServoStatus);
            this.panelControl.Controls.Add(this.label3);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.label2);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 27);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(784, 534);
            this.panelControl.TabIndex = 5;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(89, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Connection Status :";
            // 
            // btnTrigger
            // 
            this.btnTrigger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrigger.Location = new System.Drawing.Point(682, 0);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(102, 34);
            this.btnTrigger.TabIndex = 39;
            this.btnTrigger.Text = "Trigger";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAuto.Location = new System.Drawing.Point(214, 135);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(102, 34);
            this.btnAuto.TabIndex = 38;
            this.btnAuto.Text = "AUTO";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // lbConnectionStatus
            // 
            this.lbConnectionStatus.AutoSize = true;
            this.lbConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectionStatus.ForeColor = System.Drawing.Color.Blue;
            this.lbConnectionStatus.Location = new System.Drawing.Point(236, 23);
            this.lbConnectionStatus.Name = "lbConnectionStatus";
            this.lbConnectionStatus.Size = new System.Drawing.Size(140, 17);
            this.lbConnectionStatus.TabIndex = 37;
            this.lbConnectionStatus.Text = "Connection Status";
            // 
            // btnAxis3
            // 
            this.btnAxis3.Location = new System.Drawing.Point(273, 202);
            this.btnAxis3.Name = "btnAxis3";
            this.btnAxis3.Size = new System.Drawing.Size(75, 34);
            this.btnAxis3.TabIndex = 36;
            this.btnAxis3.Text = "Axis 3";
            this.btnAxis3.UseVisualStyleBackColor = true;
            this.btnAxis3.Click += new System.EventHandler(this.btnAxis3_Click);
            // 
            // btnAxis2
            // 
            this.btnAxis2.Location = new System.Drawing.Point(168, 202);
            this.btnAxis2.Name = "btnAxis2";
            this.btnAxis2.Size = new System.Drawing.Size(75, 34);
            this.btnAxis2.TabIndex = 35;
            this.btnAxis2.Text = "Axis 2";
            this.btnAxis2.UseVisualStyleBackColor = true;
            this.btnAxis2.Click += new System.EventHandler(this.btnAxis2_Click);
            // 
            // btnAxis1
            // 
            this.btnAxis1.Location = new System.Drawing.Point(59, 202);
            this.btnAxis1.Name = "btnAxis1";
            this.btnAxis1.Size = new System.Drawing.Size(75, 34);
            this.btnAxis1.TabIndex = 34;
            this.btnAxis1.Text = "Axis 1";
            this.btnAxis1.UseVisualStyleBackColor = true;
            this.btnAxis1.Click += new System.EventHandler(this.btnAxis1_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(92, 135);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(102, 34);
            this.btnManual.TabIndex = 33;
            this.btnManual.Text = "MANUAL";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(624, 441);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 34);
            this.btnStop.TabIndex = 32;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(481, 441);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 34);
            this.btnRun.TabIndex = 31;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(591, 375);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(80, 23);
            this.txtCommand.TabIndex = 30;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(480, 378);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 17);
            this.label16.TabIndex = 29;
            this.label16.Text = "Command";
            // 
            // btnLimitUp
            // 
            this.btnLimitUp.Location = new System.Drawing.Point(659, 202);
            this.btnLimitUp.Name = "btnLimitUp";
            this.btnLimitUp.Size = new System.Drawing.Size(75, 34);
            this.btnLimitUp.TabIndex = 28;
            this.btnLimitUp.Text = "Limit+";
            this.btnLimitUp.UseVisualStyleBackColor = true;
            this.btnLimitUp.Click += new System.EventHandler(this.btnLimitUp_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(554, 202);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 34);
            this.btnHome.TabIndex = 27;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLimitDown
            // 
            this.btnLimitDown.Location = new System.Drawing.Point(445, 202);
            this.btnLimitDown.Name = "btnLimitDown";
            this.btnLimitDown.Size = new System.Drawing.Size(75, 34);
            this.btnLimitDown.TabIndex = 26;
            this.btnLimitDown.Text = "Limit-";
            this.btnLimitDown.UseVisualStyleBackColor = true;
            this.btnLimitDown.Click += new System.EventHandler(this.btnLimitDown_Click);
            // 
            // txtCurrentPosition
            // 
            this.txtCurrentPosition.Location = new System.Drawing.Point(591, 141);
            this.txtCurrentPosition.Name = "txtCurrentPosition";
            this.txtCurrentPosition.Size = new System.Drawing.Size(80, 23);
            this.txtCurrentPosition.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Current Position";
            // 
            // btnJogUp
            // 
            this.btnJogUp.Location = new System.Drawing.Point(273, 441);
            this.btnJogUp.Name = "btnJogUp";
            this.btnJogUp.Size = new System.Drawing.Size(75, 34);
            this.btnJogUp.TabIndex = 23;
            this.btnJogUp.Text = "Jog+";
            this.btnJogUp.UseVisualStyleBackColor = true;
            this.btnJogUp.Click += new System.EventHandler(this.btnJogUp_Click_1);
            // 
            // btnJogDown
            // 
            this.btnJogDown.Location = new System.Drawing.Point(53, 441);
            this.btnJogDown.Name = "btnJogDown";
            this.btnJogDown.Size = new System.Drawing.Size(75, 34);
            this.btnJogDown.TabIndex = 22;
            this.btnJogDown.Text = "Jog-";
            this.btnJogDown.UseVisualStyleBackColor = true;
            this.btnJogDown.Click += new System.EventHandler(this.btnJogDown_Click_1);
            // 
            // txtJogStep
            // 
            this.txtJogStep.Location = new System.Drawing.Point(161, 447);
            this.txtJogStep.Name = "txtJogStep";
            this.txtJogStep.Size = new System.Drawing.Size(80, 23);
            this.txtJogStep.TabIndex = 21;
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(591, 321);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(80, 23);
            this.txtSpeed.TabIndex = 20;
            // 
            // labksfnns
            // 
            this.labksfnns.AutoSize = true;
            this.labksfnns.Location = new System.Drawing.Point(480, 324);
            this.labksfnns.Name = "labksfnns";
            this.labksfnns.Size = new System.Drawing.Size(49, 17);
            this.labksfnns.TabIndex = 19;
            this.labksfnns.Text = "Speed";
            // 
            // lbLampLimitUp
            // 
            this.lbLampLimitUp.AutoSize = true;
            this.lbLampLimitUp.BackColor = System.Drawing.Color.Red;
            this.lbLampLimitUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLampLimitUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbLampLimitUp.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLampLimitUp.Location = new System.Drawing.Point(287, 378);
            this.lbLampLimitUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLampLimitUp.Name = "lbLampLimitUp";
            this.lbLampLimitUp.Size = new System.Drawing.Size(29, 27);
            this.lbLampLimitUp.TabIndex = 18;
            this.lbLampLimitUp.Text = "   ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(284, 351);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 17);
            this.label15.TabIndex = 17;
            this.label15.Text = "Limit+";
            // 
            // txtAccTime
            // 
            this.txtAccTime.Location = new System.Drawing.Point(591, 268);
            this.txtAccTime.Name = "txtAccTime";
            this.txtAccTime.Size = new System.Drawing.Size(80, 23);
            this.txtAccTime.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Acc time";
            // 
            // lbLampHome
            // 
            this.lbLampHome.AutoSize = true;
            this.lbLampHome.BackColor = System.Drawing.Color.Red;
            this.lbLampHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLampHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbLampHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLampHome.Location = new System.Drawing.Point(190, 378);
            this.lbLampHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLampHome.Name = "lbLampHome";
            this.lbLampHome.Size = new System.Drawing.Size(29, 27);
            this.lbLampHome.TabIndex = 16;
            this.lbLampHome.Text = "   ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 351);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Home";
            // 
            // lbLampLimitDown
            // 
            this.lbLampLimitDown.AutoSize = true;
            this.lbLampLimitDown.BackColor = System.Drawing.Color.Red;
            this.lbLampLimitDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLampLimitDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbLampLimitDown.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLampLimitDown.Location = new System.Drawing.Point(97, 378);
            this.lbLampLimitDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLampLimitDown.Name = "lbLampLimitDown";
            this.lbLampLimitDown.Size = new System.Drawing.Size(29, 27);
            this.lbLampLimitDown.TabIndex = 14;
            this.lbLampLimitDown.Text = "   ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(94, 351);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Limit-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 293);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Servo Status";
            // 
            // lbLampServoStatus
            // 
            this.lbLampServoStatus.AutoSize = true;
            this.lbLampServoStatus.BackColor = System.Drawing.Color.Red;
            this.lbLampServoStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLampServoStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbLampServoStatus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbLampServoStatus.Location = new System.Drawing.Point(190, 286);
            this.lbLampServoStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLampServoStatus.Name = "lbLampServoStatus";
            this.lbLampServoStatus.Size = new System.Drawing.Size(29, 27);
            this.lbLampServoStatus.TabIndex = 11;
            this.lbLampServoStatus.Text = "   ";
            // 
            // UIHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UIHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Module Servo";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
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
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox txtAccTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbLampLimitUp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbLampHome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbLampLimitDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbLampServoStatus;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Label labksfnns;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnLimitUp;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLimitDown;
        private System.Windows.Forms.TextBox txtCurrentPosition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnJogUp;
        private System.Windows.Forms.Button btnJogDown;
        private System.Windows.Forms.TextBox txtJogStep;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnAxis3;
        private System.Windows.Forms.Button btnAxis2;
        private System.Windows.Forms.Button btnAxis1;
        private System.Windows.Forms.Button btnTrigger;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label lbConnectionStatus;
        private System.Windows.Forms.Label label4;
    }
}