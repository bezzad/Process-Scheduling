using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProcessScheduling
{
    public partial class ResultForm : Form
    {
        #region Global Variables
        public CheckBox btnStartStop; // For control Start/Stop Toggle button on Main Form
        public List<ProcessData> lstProcess; // Process List
        
        private System.Windows.Forms.Timer tSPN; // SPN Algorithms Timer
        private System.Windows.Forms.Timer tFCFS; // FCFS Algorithms Timer
        private System.Windows.Forms.Timer tRR; // Round Rabin (RR) Algorithms Timer

        ProcessData runningProcess; // Save Running Process in this variable
        private bool processExist = false; // Show the process is being processed or not.
        private SortedList<double, ProcessData> sortedLstProcess; // Process Sorted List by EntryTime

        private int timerSecond; // Save the amount of time spent
        private int timerInterval; // set the timer interval (millisecond)
        public int TimerInterval
        {
            get { return timerInterval; }
            set
            {
                timerInterval = value;
                //
                // set all timer intervals
                tSPN.Interval = value;
                tFCFS.Interval = value;
                tRR.Interval = value;
            }
        }

        #endregion

        public ResultForm()
        {
            InitializeComponent();

            timerSecond = 0;
            lstProcess = new List<ProcessData>();
            //
            // Set SPN Algorithm timer's
            tSPN = new Timer();
            tSPN.Tick += new EventHandler(tSPN_Tick);
            //
            // Set FCFS Algorithm timer's
            tFCFS = new Timer();
            tFCFS.Tick += new EventHandler(tFCFS_Tick);
            //
            // Set RR Algorithm timer's
            tRR = new Timer();
            tRR.Tick += new EventHandler(tRR_Tick);
            //
            // set timers interval
            TimerInterval = 100;
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            btnStartStop.BackColor = Color.LightCoral;
            btnStartStop.Text = "&Stop";
            //
            // check process list and create columns
            if (lstProcess.Count == 0) return;
            setColumns(); // create new columns by process name for any process in list
            //
            // start operation system process scheduling algorithm's
            startAlgorithm();
        }

        private void ResultForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnStartStop.BackColor = Color.LightBlue;
            btnStartStop.Text = "&Start";
            btnStartStop.Checked = false;
            //
            // stop any running timer
            tSPN.Stop();
            tFCFS.Stop();
            tRR.Stop();
        }

        private void setColumns()
        {
            for (int p = 0; p < lstProcess.Count; p++)
            {
                DataGridViewTextBoxColumn colProc = new DataGridViewTextBoxColumn();
                colProc.Name = "colProcess_" + (p + 1).ToString();
                colProc.HeaderText = "Process " + (p + 1).ToString();
                colProc.ReadOnly = true;
                colProc.SortMode = DataGridViewColumnSortMode.NotSortable;
                colProc.Resizable = DataGridViewTriState.False;
                colProc.Width = 85;
                colProc.ToolTipText =
                    string.Format("Process {0}:   Entry Time( {1} )   ,   Process Duration( {2} )",
                    (p + 1), lstProcess[p].EntryTime, lstProcess[p].Duration);
                dgvTimeScheduling.Columns.Add(colProc);
            }
        }

        private void startAlgorithm()
        {
            // find selected algorithm by user for run on OS
            switch (this.Text)
            {
                case "FCFS Algorithm":
                    {
                        setRichTextBox_Text("******** FCFS Algorithm Results ********\n", null, null); 
                        //
                        // First sort lstProcess according by EntryTime of Process Data
                        sortedLstProcess = new SortedList<double, ProcessData>();
                        foreach (var anyProc in lstProcess)
                        {
                            double key = anyProc.EntryTime;
                            while (sortedLstProcess.ContainsKey(key)) // a object added by this key!
                            {
                                key += 0.001; // change key!
                            }
                            sortedLstProcess.Add(key, anyProc);
                        }
                        //
                        // start algorithm
                        tFCFS.Start();
                    }break;
                case "SPN Algorithm":
                    {
                        setRichTextBox_Text("******** SPN Algorithm Results ********\n", null, null);
                        //
                        // start algorithm
                        tSPN.Start();
                    } break;
                case "Round Rabin Algorithm":
                    {
                        setRichTextBox_Text("********* RR Algorithm Results *********\n", null, null);
                        //
                        // First sort lstProcess according by EntryTime of Process Data
                        sortedLstProcess = new SortedList<double, ProcessData>();
                        foreach (var anyProc in lstProcess)
                        {
                            double key = anyProc.EntryTime;
                            while (sortedLstProcess.ContainsKey(key)) // a object added by this key!
                            {
                                key += 0.001; // change key!
                            }
                            sortedLstProcess.Add(key, anyProc);
                        }
                        //
                        // start algorithm
                        tRR.Start();
                    } break;
                default: 
                    {
                        MessageBox.Show("This algorithm not defined!", 
                            "Error in Algorithm Name",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                        this.Close();
                    }break;
            }
        } 

        #region RR Algorithm
        // Round Rabin Process Queue:
        Queue<ProcessData> procQueue = new Queue<ProcessData>();
        
        private int splitTime;
        public int SplitTime
        {
            get { return splitTime; }
            set { if (value > 0) splitTime = value; }
        }

        int qT = 0; // for count being time till end of quantum time's.

        /// <summary>
        /// Round Rabin
        /// In this algorithm, every process in ready to work into a queue to be first.
        /// And then handles the process of currently processed by the quantum time specified, 
        /// the head process in the queue will enter operation.
        /// </summary>
        /// <param name="sender">A Timer</param>
        /// <param name="e">Event Arguments</param>
        void tRR_Tick(object sender, EventArgs e)
        {
            dgvTimeScheduling.Rows.Add();
            dgvTimeScheduling.ClearSelection();
            dgvTimeScheduling.Rows[timerSecond].Cells[0].Value = timerSecond.ToString();
            //
            #region RR Algorithm Code
            //
            #region add any processes that can be run to Queue!
            for (int index = 0; index < sortedLstProcess.Count; index++)
            {
                if (timerSecond >= sortedLstProcess.Values[index].EntryTime) // Processes that can be run!
                {
                    procQueue.Enqueue(sortedLstProcess.Values[index]); // add process to end of queue
                    //
                    // Write Compiler Text
                    setRichTextBox_Text(
                        string.Format("{1}Process {0} was entered to Queue:{1}" +
                        "Entry Time to Ready List: {2}{1}" +
                        "Remaining Time: {3}{1}",
                        sortedLstProcess.Values[index].NumberName, Environment.NewLine,
                        sortedLstProcess.Values[index].EntryTime, sortedLstProcess.Values[index].Duration),
                        sortedLstProcess.Values[index].ProcessColor,
                        new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                    //
                    sortedLstProcess.RemoveAt(index); // remove coming process to queue from sorted ready work list
                }
                else break;
            }
            #endregion
            //
            #region Do the process is working?
            if (processExist) // Yes. exist a process in work.
            {
                #region whether the job of running process is finished or no?
                if (runningProcess.Duration > 0) //  No. it is running!
                {
                    #region Whether the cut of time has come?
                    if (qT >= splitTime) // Yes. Cut it!
                    {
                        qT = 0; // reset the counter of quantum time's.
                        //
                        // Cut running process from working time and add it to End of Queue.
                        procQueue.Enqueue(runningProcess);
                        //
                        // Write Compiler Text
                        setRichTextBox_Text(
                            string.Format("{0}Process {1} was blocked by dispatcher.{0}" +
                                          "and move it to ready queue list at time ({2}){0}",
                                          Environment.NewLine, runningProcess.NumberName, timerSecond),
                            runningProcess.ProcessColor,
                            new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                        //
                        // Peek new process of Queue Heads to work 
                        runningProcess = procQueue.Dequeue();
                        //
                        // Write Compiler Text
                        setRichTextBox_Text(
                            string.Format("{0}Process {1} was Resume or Started by dispatcher.{0}" +
                                          "Start Time: {2}{0}Remaining Time: {3}{0}",
                                          Environment.NewLine, runningProcess.NumberName,
                                          timerSecond, runningProcess.Duration),
                            runningProcess.ProcessColor,
                            new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                        //
                        dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                        runningProcess.Duration--; // work this process at this time!
                    }
                    else // No. Continue ...
                    {
                        dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                        runningProcess.Duration--; // continue this process work!
                    }
                    #endregion
                }
                else // Yes. it's job Finished!
                {
                    qT = 0; // reset the counter of quantum time's.
                    //
                    // Write Compiler Text
                    setRichTextBox_Text(
                        string.Format("{0}Process {1} was completed at time ({2}){0}",
                                      Environment.NewLine, runningProcess.NumberName,
                                      timerSecond),
                        runningProcess.ProcessColor,
                        new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                    //
                    #region Is Ready Process Queue Empty?
                    if (procQueue.Count > 0) // No, exist ready process in Queue.
                    {
                        runningProcess = procQueue.Dequeue();
                        //
                        // Write Compiler Text
                        setRichTextBox_Text(
                            string.Format("{0}Process {1} was Resume or Started by dispatcher.{0}" +
                                          "Start Time: {2}{0}Remaining Time: {3}{0}",
                                          Environment.NewLine, runningProcess.NumberName,
                                          timerSecond, runningProcess.Duration),
                            runningProcess.ProcessColor,
                            new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                        //
                        dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                        runningProcess.Duration--;
                    }
                    else // Yes, the process ready queue is empty!
                    {
                        processExist = false;
                        timerSecond++;
                        return;
                    }
                    #endregion
                }
                #endregion
            }
            else // No. Processor is less-jobs!
            {
                #region is process Queue empty?
                if (procQueue.Count > 0) // No.
                {
                    qT = 0;
                    //
                    runningProcess = procQueue.Dequeue();
                    processExist = true;
                    //
                    // Write Compiler Text
                    setRichTextBox_Text(
                        string.Format("{0}Process {1} was Resume or Started by dispatcher.{0}" +
                                      "Start Time: {2}{0}Remaining Time: {3}{0}",
                                      Environment.NewLine, runningProcess.NumberName,
                                      timerSecond, runningProcess.Duration),
                        runningProcess.ProcessColor,
                        new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                    //
                    dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                    runningProcess.Duration--;
                }
                else // yes. the queue is empty of any process!
                {
                    // 
                    #region Exist any process (not ready or coming process) in sorted list?
                    if (sortedLstProcess.Count > 0) // yes, exist.
                    {
                        qT = 0;
                        timerSecond++;
                        return;
                    }
                    else // No. End of All Works.
                    {
                        tRR.Stop();
                        setRichTextBox_Text(Environment.NewLine + "******** Algorithm Completed! ********\n", null, null);
                        MessageBox.Show("The End", "RR Algorithm",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    #endregion
                }
                #endregion
            }
            #endregion
            #endregion
            //
            timerSecond++;
            qT++;
            //
            // set dataGridView Scroll to end of page
            try { this.dgvTimeScheduling.FirstDisplayedScrollingRowIndex++; }
            catch { }
        }
        #endregion

        #region FCFS Algorithm
     
        /// <summary>
        /// First Come First Serve
        /// In this scheduling algorithm, any process that will soon enter, 
        /// the sooner will run and kind of a queue for all processes to be considered.
        /// </summary>
        /// <param name="sender">A Timer</param>
        /// <param name="e">Event Arguments</param>
        void tFCFS_Tick(object sender, EventArgs e)
        {
            dgvTimeScheduling.Rows.Add();
            dgvTimeScheduling.ClearSelection();
            dgvTimeScheduling.Rows[timerSecond].Cells[0].Value = timerSecond.ToString();
            //
            #region FCFS Algorithm Code
        runProcess:
            if (!processExist) // Whether a process is being processed ? No.
            {
                if (sortedLstProcess.Count == 0) // End of work
                {
                    tFCFS.Stop();
                    setRichTextBox_Text(Environment.NewLine + "******** Algorithm Completed! ********\n", null, null);
                    MessageBox.Show("The End", "FCFS Algorithm", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (timerSecond >= sortedLstProcess.Values[0].EntryTime) // Processes that can be run!
                {
                    runningProcess = sortedLstProcess.Values[0];
                    processExist = true;
                    dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                    //
                    // Write Compiler Text
                    setRichTextBox_Text(
                        string.Format("{1}Process {0} was entered:{1}Entry Time to Ready List: {2}{1}", 
                        runningProcess.NumberName, Environment.NewLine, runningProcess.EntryTime),
                        runningProcess.ProcessColor, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));

                    setRichTextBox_Text(
                        string.Format("Start Time: {1}{0}Waiting Time: {2}{0}Remaining Time: {3}{0}",
                        Environment.NewLine, timerSecond, (timerSecond - runningProcess.EntryTime), runningProcess.Duration),
                        runningProcess.ProcessColor, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                    //
                    runningProcess.Duration--;
                }
            }
            else // exist a running process
            {
                if (runningProcess.Duration > 0)
                {
                    dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                    runningProcess.Duration--;
                }
                else // end of the process worker
                {
                    //
                    // Write Compiler Text
                    setRichTextBox_Text(
                        string.Format("Process {0} was completed at time ({1}){2}", runningProcess.NumberName, timerSecond, Environment.NewLine),
                        runningProcess.ProcessColor, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                    //
                    processExist = false;
                    sortedLstProcess.RemoveAt(0);
                    goto runProcess;
                }
            }
            #endregion
            //
            timerSecond++;
            //
            // set dataGridView Scroll to end of page
            try { this.dgvTimeScheduling.FirstDisplayedScrollingRowIndex++; }
            catch { }
        }
        #endregion

        #region SPN Algorithm
        List<ProcessData> lstAvailableProcess = new List<ProcessData>();
        List<int> lstProcessedName = new List<int>();

        /// <summary>
        /// Shortest Process Next
        /// In this scheduling algorithm, reserve process in time for the operating system, 
        /// each ready to work process that the shortest period of time will have run is selected.
        /// </summary>
        /// <param name="sender">A Timer</param>
        /// <param name="e">Event Arguments</param>
        void tSPN_Tick(object sender, EventArgs e)
        {
            dgvTimeScheduling.Rows.Add();
            dgvTimeScheduling.ClearSelection();
            dgvTimeScheduling.Rows[timerSecond].Cells[0].Value = timerSecond.ToString();
            //
            #region SPN Algorithm Code
        runProcess:
            if (!processExist) // Whether a process is being processed ? No
            {
                if (lstProcess.Count == lstProcessedName.Count) // End of work, because not exist any ready process in list
                {
                    tSPN.Stop();
                    setRichTextBox_Text(Environment.NewLine + "******** Algorithm Completed! ********\n", null, null);
                    MessageBox.Show("The End", "SPN Algorithm",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    foreach (var anyMinProc in lstProcess)
                    {
                        // Check process to be sure that has not processed already.
                        if (!lstProcessedName.Contains(anyMinProc.NumberName)) 
                            if (timerSecond >= anyMinProc.EntryTime) // Processes that can be run!
                                lstAvailableProcess.Add(anyMinProc);
                    }
                    if (lstAvailableProcess.Count > 0)
                    {
                        // find minimum duration Process in Available Process List
                        runningProcess = lstAvailableProcess[0];
                        for (int p = 1; p < lstAvailableProcess.Count; p++) // search minimum duration process
                            if (lstAvailableProcess[p].Duration < runningProcess.Duration)
                                runningProcess = lstAvailableProcess[p];

                        processExist = true;
                        dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                        //
                        // Write Compiler Text
                        setRichTextBox_Text(
                            string.Format("{1}Process {0} was entered:{1}Entry Time to Ready List: {2}{1}",
                            runningProcess.NumberName, Environment.NewLine, runningProcess.EntryTime),
                            runningProcess.ProcessColor, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));

                        setRichTextBox_Text(
                            string.Format("Start Time: {1}{0}Waiting Time: {2}{0}Remaining Time: {3}{0}",
                            Environment.NewLine, timerSecond, (timerSecond - runningProcess.EntryTime), runningProcess.Duration),
                            runningProcess.ProcessColor, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                        //
                        runningProcess.Duration--;
                    }
                }
            }
            else // exist a running process
            {
                if (runningProcess.Duration > 0)
                {
                    dgvTimeScheduling[runningProcess.NumberName, timerSecond].Style.BackColor = runningProcess.ProcessColor;
                    runningProcess.Duration--;
                }
                else // end of the process worker
                {
                    //
                    // Write Compiler Text
                    setRichTextBox_Text(
                        string.Format("Process {0} was completed at time ({1}){2}", runningProcess.NumberName, timerSecond, Environment.NewLine),
                        runningProcess.ProcessColor, new Font("Microsoft Sans Serif", 10F, FontStyle.Bold));
                    //
                    processExist = false;
                    lstProcessedName.Add(runningProcess.NumberName);
                    lstAvailableProcess.Clear();
                    goto runProcess;
                }
            }
            #endregion
            //
            timerSecond++;
            //
            // set dataGridView Scroll to end of page
            try { this.dgvTimeScheduling.FirstDisplayedScrollingRowIndex++; }
            catch { }
        }
        #endregion

        /// <summary>
        /// Set rtxtResult Text by special color and fonts
        /// </summary>
        /// <param name="text">what text append to rtxtResult</param>
        /// <param name="color">appended text colors. Default value is "Black"</param>
        /// <param name="font">appended text fonts. Default value is "Tahoma, 10, Regular"</param>
        
        private void setRichTextBox_Text(string text, Color? color, object font)
        {
            try
            {
                //
                // set default values
                //
                if (font == null || !(font is Font)) // setup the font
                    font = new System.Drawing.Font("Tahoma", 10, FontStyle.Regular);
                if (!color.HasValue) // setup the line color
                    color = Color.Black;
                //
                // append text to richTextBox
                //
                rtxtResult.SelectionFont = font as Font;
                rtxtResult.SelectionColor = color.Value;
                rtxtResult.SelectedText = text;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Source); }
        }
    }

    public struct ProcessData
    {
        public int EntryTime;
        public int Duration;
        public Color ProcessColor;
        public int NumberName;
    }
}
