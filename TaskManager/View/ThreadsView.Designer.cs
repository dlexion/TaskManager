namespace TaskManager.View
{
    partial class ThreadsView
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridViewThreads = new System.Windows.Forms.DataGridView();
            this.tsslThreadsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslThreadsCountValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThreads)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslThreadsCount,
            this.tsslThreadsCountValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 452);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(531, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridViewThreads
            // 
            this.dataGridViewThreads.AllowUserToAddRows = false;
            this.dataGridViewThreads.AllowUserToDeleteRows = false;
            this.dataGridViewThreads.AllowUserToOrderColumns = true;
            this.dataGridViewThreads.AllowUserToResizeRows = false;
            this.dataGridViewThreads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewThreads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewThreads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewThreads.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewThreads.Name = "dataGridViewThreads";
            this.dataGridViewThreads.ReadOnly = true;
            this.dataGridViewThreads.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewThreads.Size = new System.Drawing.Size(531, 452);
            this.dataGridViewThreads.TabIndex = 0;
            // 
            // tsslThreadsCount
            // 
            this.tsslThreadsCount.Name = "tsslThreadsCount";
            this.tsslThreadsCount.Size = new System.Drawing.Size(86, 17);
            this.tsslThreadsCount.Text = "Threads count:";
            // 
            // tsslThreadsCountValue
            // 
            this.tsslThreadsCountValue.Name = "tsslThreadsCountValue";
            this.tsslThreadsCountValue.Size = new System.Drawing.Size(13, 17);
            this.tsslThreadsCountValue.Text = "0";
            // 
            // ThreadsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 474);
            this.Controls.Add(this.dataGridViewThreads);
            this.Controls.Add(this.statusStrip1);
            this.Name = "ThreadsView";
            this.Text = "ThreadsView";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewThreads)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslThreadsCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslThreadsCountValue;
        private System.Windows.Forms.DataGridView dataGridViewThreads;
    }
}