namespace TaskManager.View
{
    partial class ProcessesView
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslProcesses = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslProcessesCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMemoryUsage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMemoryUsageValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(800, 425);
            this.dataGridView.TabIndex = 0;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcesses,
            this.tsslProcessesCount,
            this.tsslMemoryUsage,
            this.tsslMemoryUsageValue});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusTrip";
            // 
            // tsslProcesses
            // 
            this.tsslProcesses.Name = "tsslProcesses";
            this.tsslProcesses.Size = new System.Drawing.Size(61, 17);
            this.tsslProcesses.Text = "Processes:";
            // 
            // tsslProcessesCount
            // 
            this.tsslProcessesCount.Name = "tsslProcessesCount";
            this.tsslProcessesCount.Size = new System.Drawing.Size(13, 17);
            this.tsslProcessesCount.Text = "0";
            // 
            // tsslMemoryUsage
            // 
            this.tsslMemoryUsage.Name = "tsslMemoryUsage";
            this.tsslMemoryUsage.Size = new System.Drawing.Size(89, 17);
            this.tsslMemoryUsage.Text = "Memory usage:";
            // 
            // tsslMemoryUsageValue
            // 
            this.tsslMemoryUsageValue.Name = "tsslMemoryUsageValue";
            this.tsslMemoryUsageValue.Size = new System.Drawing.Size(13, 17);
            this.tsslMemoryUsageValue.Text = "0";
            // 
            // ProcessesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.dataGridView);
            this.Name = "ProcessesView";
            this.Text = "ProcessesView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcesses;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcessesCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslMemoryUsage;
        private System.Windows.Forms.ToolStripStatusLabel tsslMemoryUsageValue;
    }
}