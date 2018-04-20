namespace ProcessScheduling
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbProcessData = new System.Windows.Forms.GroupBox();
            this.panelProcessInfo = new System.Windows.Forms.Panel();
            this.btnAddProcess = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnToggleStartStop = new System.Windows.Forms.CheckBox();
            this.btnRemoveProcess = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.rbtnSPN = new System.Windows.Forms.RadioButton();
            this.rbtnFCFS = new System.Windows.Forms.RadioButton();
            this.rbtnRR = new System.Windows.Forms.RadioButton();
            this.numRR = new System.Windows.Forms.NumericUpDown();
            this.trbInterval = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumProcess = new System.Windows.Forms.Label();
            this.lblNumRR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grbProcessData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 26F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(63, 4);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(558, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Process Scheduling Algorithms Simulator";
            // 
            // grbProcessData
            // 
            this.grbProcessData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grbProcessData.Controls.Add(this.panelProcessInfo);
            this.grbProcessData.Location = new System.Drawing.Point(12, 50);
            this.grbProcessData.Name = "grbProcessData";
            this.grbProcessData.Size = new System.Drawing.Size(660, 240);
            this.grbProcessData.TabIndex = 1;
            this.grbProcessData.TabStop = false;
            this.grbProcessData.Text = "Process Data";
            // 
            // panelProcessInfo
            // 
            this.panelProcessInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProcessInfo.AutoScroll = true;
            this.panelProcessInfo.BackColor = System.Drawing.Color.Bisque;
            this.panelProcessInfo.Location = new System.Drawing.Point(6, 19);
            this.panelProcessInfo.Name = "panelProcessInfo";
            this.panelProcessInfo.Size = new System.Drawing.Size(648, 215);
            this.panelProcessInfo.TabIndex = 0;
            // 
            // btnAddProcess
            // 
            this.btnAddProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProcess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProcess.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAddProcess.Location = new System.Drawing.Point(106, 296);
            this.btnAddProcess.Name = "btnAddProcess";
            this.btnAddProcess.Size = new System.Drawing.Size(145, 28);
            this.btnAddProcess.TabIndex = 0;
            this.btnAddProcess.Text = "Add New Process";
            this.toolTip1.SetToolTip(this.btnAddProcess, "Add a new process info to Process Data Panels.");
            this.btnAddProcess.UseVisualStyleBackColor = true;
            this.btnAddProcess.Click += new System.EventHandler(this.btnAddProcess_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            // 
            // btnToggleStartStop
            // 
            this.btnToggleStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToggleStartStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnToggleStartStop.AutoSize = true;
            this.btnToggleStartStop.BackColor = System.Drawing.Color.LightBlue;
            this.btnToggleStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnToggleStartStop.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleStartStop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnToggleStartStop.Location = new System.Drawing.Point(18, 293);
            this.btnToggleStartStop.Name = "btnToggleStartStop";
            this.btnToggleStartStop.Size = new System.Drawing.Size(58, 31);
            this.btnToggleStartStop.TabIndex = 3;
            this.btnToggleStartStop.Text = "&Start";
            this.toolTip1.SetToolTip(this.btnToggleStartStop, "Toggle Between Start / Stop");
            this.btnToggleStartStop.UseVisualStyleBackColor = false;
            this.btnToggleStartStop.CheckedChanged += new System.EventHandler(this.btnToggleStartStop_CheckedChanged);
            // 
            // btnRemoveProcess
            // 
            this.btnRemoveProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveProcess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProcess.ForeColor = System.Drawing.Color.Crimson;
            this.btnRemoveProcess.Location = new System.Drawing.Point(257, 296);
            this.btnRemoveProcess.Name = "btnRemoveProcess";
            this.btnRemoveProcess.Size = new System.Drawing.Size(165, 28);
            this.btnRemoveProcess.TabIndex = 7;
            this.btnRemoveProcess.Text = "Remove Last Process";
            this.toolTip1.SetToolTip(this.btnRemoveProcess, "Remove the last process in list.");
            this.btnRemoveProcess.UseVisualStyleBackColor = true;
            this.btnRemoveProcess.Click += new System.EventHandler(this.btnRemoveProcess_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.Crimson;
            this.btnClearAll.Location = new System.Drawing.Point(428, 296);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(77, 28);
            this.btnClearAll.TabIndex = 7;
            this.btnClearAll.Text = "Clear All";
            this.toolTip1.SetToolTip(this.btnClearAll, "Clear all created process.");
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // rbtnSPN
            // 
            this.rbtnSPN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnSPN.AutoSize = true;
            this.rbtnSPN.Checked = true;
            this.rbtnSPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnSPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtnSPN.Location = new System.Drawing.Point(12, 344);
            this.rbtnSPN.Name = "rbtnSPN";
            this.rbtnSPN.Size = new System.Drawing.Size(66, 28);
            this.rbtnSPN.TabIndex = 0;
            this.rbtnSPN.TabStop = true;
            this.rbtnSPN.Text = "SPN";
            this.toolTip1.SetToolTip(this.rbtnSPN, "Shortest Process Next");
            this.rbtnSPN.UseVisualStyleBackColor = true;
            // 
            // rbtnFCFS
            // 
            this.rbtnFCFS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnFCFS.AutoSize = true;
            this.rbtnFCFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnFCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtnFCFS.Location = new System.Drawing.Point(172, 344);
            this.rbtnFCFS.Name = "rbtnFCFS";
            this.rbtnFCFS.Size = new System.Drawing.Size(77, 28);
            this.rbtnFCFS.TabIndex = 1;
            this.rbtnFCFS.Text = "FCFS";
            this.toolTip1.SetToolTip(this.rbtnFCFS, "First Come First Serve");
            this.rbtnFCFS.UseVisualStyleBackColor = true;
            // 
            // rbtnRR
            // 
            this.rbtnRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rbtnRR.AutoSize = true;
            this.rbtnRR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbtnRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.rbtnRR.Location = new System.Drawing.Point(92, 344);
            this.rbtnRR.Name = "rbtnRR";
            this.rbtnRR.Size = new System.Drawing.Size(54, 28);
            this.rbtnRR.TabIndex = 2;
            this.rbtnRR.Text = "RR";
            this.toolTip1.SetToolTip(this.rbtnRR, "Round Rabin");
            this.rbtnRR.UseVisualStyleBackColor = true;
            this.rbtnRR.CheckedChanged += new System.EventHandler(this.rbtnRR_CheckedChanged);
            // 
            // numRR
            // 
            this.numRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numRR.Location = new System.Drawing.Point(632, 347);
            this.numRR.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRR.Name = "numRR";
            this.numRR.Size = new System.Drawing.Size(40, 20);
            this.numRR.TabIndex = 8;
            this.numRR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRR.ThousandsSeparator = true;
            this.toolTip1.SetToolTip(this.numRR, "Time Quantum");
            this.numRR.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRR.Visible = false;
            this.numRR.ValueChanged += new System.EventHandler(this.numRR_ValueChanged);
            // 
            // trbInterval
            // 
            this.trbInterval.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trbInterval.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trbInterval.Location = new System.Drawing.Point(257, 338);
            this.trbInterval.Maximum = 1000;
            this.trbInterval.Minimum = 1;
            this.trbInterval.Name = "trbInterval";
            this.trbInterval.Size = new System.Drawing.Size(234, 45);
            this.trbInterval.SmallChange = 50;
            this.trbInterval.TabIndex = 10;
            this.trbInterval.TickFrequency = 50;
            this.toolTip1.SetToolTip(this.trbInterval, "Set Timer Interval");
            this.trbInterval.Value = 100;
            this.trbInterval.Scroll += new System.EventHandler(this.trbInterval_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(515, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Process:";
            // 
            // lblNumProcess
            // 
            this.lblNumProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumProcess.AutoSize = true;
            this.lblNumProcess.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProcess.ForeColor = System.Drawing.Color.Red;
            this.lblNumProcess.Location = new System.Drawing.Point(633, 301);
            this.lblNumProcess.Name = "lblNumProcess";
            this.lblNumProcess.Size = new System.Drawing.Size(16, 18);
            this.lblNumProcess.TabIndex = 6;
            this.lblNumProcess.Text = "0";
            // 
            // lblNumRR
            // 
            this.lblNumRR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumRR.AutoSize = true;
            this.lblNumRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblNumRR.Location = new System.Drawing.Point(497, 348);
            this.lblNumRR.Name = "lblNumRR";
            this.lblNumRR.Size = new System.Drawing.Size(132, 16);
            this.lblNumRR.TabIndex = 9;
            this.lblNumRR.Text = "Enter Time Quantum:";
            this.lblNumRR.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(266, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 9);
            this.label2.TabIndex = 11;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(283, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 9);
            this.label3.TabIndex = 11;
            this.label3.Text = "100";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(303, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 9);
            this.label4.TabIndex = 11;
            this.label4.Text = "200";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(324, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 9);
            this.label5.TabIndex = 11;
            this.label5.Text = "300";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(345, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 9);
            this.label6.TabIndex = 11;
            this.label6.Text = "400";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(366, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 9);
            this.label7.TabIndex = 11;
            this.label7.Text = "500";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(386, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 9);
            this.label8.TabIndex = 11;
            this.label8.Text = "600";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(407, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 9);
            this.label9.TabIndex = 11;
            this.label9.Text = "700";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(428, 367);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 9);
            this.label10.TabIndex = 11;
            this.label10.Text = "800";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(448, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 9);
            this.label11.TabIndex = 11;
            this.label11.Text = "900";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(467, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 9);
            this.label12.TabIndex = 11;
            this.label12.Text = "1000";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 396);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trbInterval);
            this.Controls.Add(this.lblNumRR);
            this.Controls.Add(this.numRR);
            this.Controls.Add(this.rbtnRR);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.rbtnFCFS);
            this.Controls.Add(this.rbtnSPN);
            this.Controls.Add(this.btnRemoveProcess);
            this.Controls.Add(this.lblNumProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddProcess);
            this.Controls.Add(this.btnToggleStartStop);
            this.Controls.Add(this.grbProcessData);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 300);
            this.Name = "MainForm";
            this.Text = "Process Scheduling";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.grbProcessData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numRR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grbProcessData;
        private System.Windows.Forms.Panel panelProcessInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox btnToggleStartStop;
        private System.Windows.Forms.Button btnAddProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumProcess;
        private System.Windows.Forms.Button btnRemoveProcess;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.RadioButton rbtnSPN;
        private System.Windows.Forms.RadioButton rbtnFCFS;
        private System.Windows.Forms.RadioButton rbtnRR;
        private System.Windows.Forms.NumericUpDown numRR;
        private System.Windows.Forms.Label lblNumRR;
        private System.Windows.Forms.TrackBar trbInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

