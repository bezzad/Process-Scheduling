using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProcessScheduling
{
    public partial class MainForm : Form
    {
        // Global Variables
        List<ProcessInfo> lstProcInfo = new List<ProcessInfo>();
        ResultForm result;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            lblTitle.Location = new Point(Math.Abs(this.ClientSize.Width - lblTitle.Width) / 2, lblTitle.Location.Y);
        }
        
        private void btnToggleStartStop_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                // Now is Stop Button
                if (((CheckBox)sender).Checked)
                {
                    // Create result form by special algorithm 
                    result = new ResultForm();
                    result.SplitTime = (int)this.numRR.Value;
                    result.btnStartStop = this.btnToggleStartStop; // do equal two object reference.
                    result.TimerInterval = this.trbInterval.Value; // Set all timer intervals
                    result.Text = (rbtnFCFS.Checked) ? "FCFS Algorithm" :
                                  (rbtnRR.Checked) ? "Round Rabin Algorithm" :
                                  "SPN Algorithm";
                    //
                    // send Process Info to Result form and in Process Data list
                    Random rand = new Random();
                    foreach (var anyProc in lstProcInfo)
                    {
                        var proc = new ProcessData();
                        if (!int.TryParse(anyProc.txtArrivalTime.Text, out proc.EntryTime))
                            throw new Exception("Please Fill all Textboxes of all Process!");
                        if (!int.TryParse(anyProc.txtProcessDuration.Text, out proc.Duration))
                            throw new Exception("Please Fill all Textboxes of all Process!");

                        proc.ProcessColor = Color.FromArgb(rand.Next(15, 235), rand.Next(15, 235), rand.Next(15, 235));
                        proc.NumberName = anyProc.processNumber;

                        result.lstProcess.Add(proc);
                    }
                    //
                    // show result form
                    result.Show();
                }
                // Now is Start Button
                else
                {
                    result.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.Source);
                this.btnToggleStartStop.BackColor = Color.LightBlue;
                this.btnToggleStartStop.Text = "&Start";
                this.btnToggleStartStop.Checked = false;
            }
        }

        private void btnAddProcess_Click(object sender, EventArgs e)
        {
            this.panelProcessInfo.VerticalScroll.Value = 0;
            int LastNumber = this.lstProcInfo.Count;
            lstProcInfo.Add(new ProcessInfo(LastNumber + 1, new Point(3, 7 + (46 * LastNumber))));
            this.panelProcessInfo.Controls.Add(lstProcInfo[LastNumber].mainPanel);
            LastNumber++;
            this.lblNumProcess.Text = LastNumber.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            btnAddProcess_Click(sender, e);
        }

        private void btnRemoveProcess_Click(object sender, EventArgs e)
        {
            if (lstProcInfo.Count > 1) // minimum exist process is 1
            {
                this.panelProcessInfo.Controls.Remove(lstProcInfo[lstProcInfo.Count - 1].mainPanel);
                this.lstProcInfo.RemoveAt(lstProcInfo.Count - 1);
                this.lblNumProcess.Text = lstProcInfo.Count.ToString();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            this.panelProcessInfo.Controls.Clear();
            this.lstProcInfo.Clear();
            btnAddProcess_Click(sender, e);
        }

        private void rbtnRR_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRR.Checked)
            {
                lblNumRR.Visible = true;
                numRR.Visible = true;
                numRR.Value = 5;
            }
            else
            {
                lblNumRR.Visible = false;
                numRR.Visible = false;
            }
        }

        private void trbInterval_Scroll(object sender, EventArgs e)
        {
            if (result != null)
                result.TimerInterval = this.trbInterval.Value; // Set all timer intervals
        }

        private void numRR_ValueChanged(object sender, EventArgs e)
        {
            if (result != null)
                result.SplitTime = (int)this.numRR.Value;
        }
    }

    public class ProcessInfo
    {
        public Panel mainPanel;
        public Label lblProcessName;
        public TextBox txtArrivalTime;
        public TextBox txtProcessDuration;
        public int processNumber;

        private ToolTip TT;

        // all the members of the struct has to be initialized in this way
        public ProcessInfo(int procNumber, Point panelLocation)
        {
            processNumber = procNumber;
            TT = initialize_ToolTipTT();
            mainPanel = initialize_Panel(panelLocation);
            lblProcessName = initialize_Label();
            txtArrivalTime = initialize_TextBoxArrivalTime();
            txtProcessDuration = initialize_TextBoxProcessDuration();
            this.mainPanel.Controls.AddRange(new Control[] {lblProcessName, txtArrivalTime, txtProcessDuration});
            this.mainPanel.ResumeLayout(false);
        }

        #region TextBoxes Events
        #region txtProcessDuration Events
        private void txtProcessDuration_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "Process Duration")
            {
                // clear text
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void txtProcessDuration_MouseLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // set default text
                ((TextBox)sender).Text = "Process Duration";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }

        private void txtProcessDuration_KeyDown(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text == "Process Duration")
            {
                // clear text
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void txtProcessDuration_KeyUp(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // set default text
                ((TextBox)sender).Text = "Process Duration";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }
        #endregion
        #region txtArrivalTime Events
        private void txtArrivalTime_KeyDown(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text == "Arrival Time")
            {
                // clear text
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void txtArrivalTime_KeyUp(object sender, KeyEventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // set default text
                ((TextBox)sender).Text = "Arrival Time";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }

        private void txtArrivalTime_MouseDown(object sender, MouseEventArgs e)
        {
            if (((TextBox)sender).Text == "Arrival Time")
            {
                // clear text
                ((TextBox)sender).Text = "";
                ((TextBox)sender).ForeColor = Color.Black;
            }
        }

        private void txtArrivalTime_MouseLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text == "")
            {
                // set default text
                ((TextBox)sender).Text = "Arrival Time";
                ((TextBox)sender).ForeColor = Color.Gray;
            }
        }
        #endregion

        /// <summary>
        /// key Press event for Numerical textbox
        /// </summary>
        /// <param name="sender">A TextBox</param>
        /// <param name="e">key Press Event Arguments</param>
        private void txtNumerical_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                if (e.KeyChar != '') // this char is Backspace and not A SPACE!
                {
                    e.Handled = true;
                }
        }
        #endregion

        private Panel initialize_Panel(Point position)
        {
            Panel pnlMain = new Panel();

            pnlMain.BackColor = System.Drawing.Color.Honeydew;
            pnlMain.Location = position;
            pnlMain.Name = "pnlMain" + processNumber.ToString();
            pnlMain.Size = new System.Drawing.Size(624, 40);
            pnlMain.TabIndex = 0;

            return pnlMain;
        }

        private Label initialize_Label()
        {
            Label lblPN = new Label();

            lblPN.AutoSize = true;
            lblPN.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPN.ForeColor = System.Drawing.SystemColors.HotTrack;
            lblPN.Location = new System.Drawing.Point(12, 8);
            lblPN.Name = "lblPN";
            lblPN.Size = new System.Drawing.Size(98, 24);
            lblPN.TabIndex = 0;
            lblPN.Text = String.Format("Process {0}: ", processNumber.ToString());

            return lblPN;
        }

        private TextBox initialize_TextBoxArrivalTime()
        {
            TextBox txtAT = new TextBox();

            txtAT.ForeColor = System.Drawing.Color.Gray;
            txtAT.Location = new System.Drawing.Point(195, 11);
            txtAT.MaxLength = 3;
            txtAT.Name = "txtArrivalTime";
            txtAT.Size = new System.Drawing.Size(107, 20);
            txtAT.TabIndex = 1;
            txtAT.Text = "Arrival Time";
            txtAT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TT.SetToolTip(txtAT, "Entry time of this process (×100 millisecond)");
            txtAT.KeyDown += new System.Windows.Forms.KeyEventHandler(txtArrivalTime_KeyDown);
            txtAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerical_KeyPress);
            txtAT.KeyUp += new System.Windows.Forms.KeyEventHandler(txtArrivalTime_KeyUp);
            txtAT.MouseDown += new System.Windows.Forms.MouseEventHandler(txtArrivalTime_MouseDown);
            txtAT.MouseLeave += new System.EventHandler(txtArrivalTime_MouseLeave);

            return txtAT;
        }

        private TextBox initialize_TextBoxProcessDuration()
        {
            TextBox txtPD = new TextBox();

            txtPD.ForeColor = System.Drawing.Color.Gray;
            txtPD.Location = new System.Drawing.Point(322, 11);
            txtPD.MaxLength = 3;
            txtPD.Name = "txtProcessDuration";
            txtPD.Size = new System.Drawing.Size(107, 20);
            txtPD.TabIndex = 1;
            txtPD.Text = "Process Duration";
            txtPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TT.SetToolTip(txtPD, "Process duration (×100 millisecond)");
            txtPD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProcessDuration_KeyDown);
            txtPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerical_KeyPress);
            txtPD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtProcessDuration_KeyUp);
            txtPD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtProcessDuration_MouseDown);
            txtPD.MouseLeave += new System.EventHandler(this.txtProcessDuration_MouseLeave);

            return txtPD;
        }

        private ToolTip initialize_ToolTipTT()
        {
            ToolTip toolTipTT = new ToolTip();

            toolTipTT.AutomaticDelay = 100;
            toolTipTT.AutoPopDelay = 10000;
            toolTipTT.InitialDelay = 100;
            toolTipTT.ReshowDelay = 20;
            toolTipTT.ShowAlways = true;
            toolTipTT.StripAmpersands = true;

            return toolTipTT;
        }
    }
}
