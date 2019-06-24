namespace ProcessScheduling
{
    partial class ResultForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTimeScheduling = new System.Windows.Forms.DataGridView();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeScheduling)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTimeScheduling
            // 
            this.dgvTimeScheduling.AllowUserToAddRows = false;
            this.dgvTimeScheduling.AllowUserToDeleteRows = false;
            this.dgvTimeScheduling.AllowUserToResizeRows = false;
            this.dgvTimeScheduling.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTimeScheduling.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvTimeScheduling.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimeScheduling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTimeScheduling.ColumnHeadersHeight = 35;
            this.dgvTimeScheduling.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTimeScheduling.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTime});
            this.dgvTimeScheduling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimeScheduling.Location = new System.Drawing.Point(0, 0);
            this.dgvTimeScheduling.Name = "dgvTimeScheduling";
            this.dgvTimeScheduling.ReadOnly = true;
            this.dgvTimeScheduling.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTimeScheduling.RowHeadersVisible = false;
            this.dgvTimeScheduling.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTimeScheduling.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTimeScheduling.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTimeScheduling.RowTemplate.Height = 25;
            this.dgvTimeScheduling.RowTemplate.ReadOnly = true;
            this.dgvTimeScheduling.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeScheduling.Size = new System.Drawing.Size(368, 457);
            this.dgvTimeScheduling.TabIndex = 0;
            // 
            // colTime
            // 
            this.colTime.Frozen = true;
            this.colTime.HeaderText = "Time (sec)";
            this.colTime.MinimumWidth = 20;
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTime.ToolTipText = "Timer Tak Tick";
            // 
            // rtxtResult
            // 
            this.rtxtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtResult.Location = new System.Drawing.Point(378, 0);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ReadOnly = true;
            this.rtxtResult.Size = new System.Drawing.Size(305, 461);
            this.rtxtResult.TabIndex = 1;
            this.rtxtResult.Text = "";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dgvTimeScheduling);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(372, 461);
            this.panel1.TabIndex = 2;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rtxtResult);
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResultForm_FormClosing);
            this.Load += new System.EventHandler(this.ResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeScheduling)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTimeScheduling;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.Panel panel1;
    }
}