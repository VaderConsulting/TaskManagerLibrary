namespace TaskManager
{
    partial class TaskManager
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.picTaskCount = new System.Windows.Forms.PictureBox();
			this.pbrTask = new System.Windows.Forms.ProgressBar();
			this.cmbStatus = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.picTaskCount)).BeginInit();
			this.SuspendLayout();
			// 
			// picTaskCount
			// 
			this.picTaskCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.picTaskCount.Location = new System.Drawing.Point(3, 3);
			this.picTaskCount.Name = "picTaskCount";
			this.picTaskCount.Size = new System.Drawing.Size(33, 33);
			this.picTaskCount.TabIndex = 0;
			this.picTaskCount.TabStop = false;
			// 
			// pbrTask
			// 
			this.pbrTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbrTask.Location = new System.Drawing.Point(42, 27);
			this.pbrTask.Name = "pbrTask";
			this.pbrTask.Size = new System.Drawing.Size(278, 9);
			this.pbrTask.TabIndex = 1;
			// 
			// cmbStatus
			// 
			this.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbStatus.BackColor = System.Drawing.SystemColors.Control;
			this.cmbStatus.FormattingEnabled = true;
			this.cmbStatus.Location = new System.Drawing.Point(42, 3);
			this.cmbStatus.Name = "cmbStatus";
			this.cmbStatus.Size = new System.Drawing.Size(278, 21);
			this.cmbStatus.TabIndex = 3;
			// 
			// TaskManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.cmbStatus);
			this.Controls.Add(this.pbrTask);
			this.Controls.Add(this.picTaskCount);
			this.Name = "TaskManager";
			this.Size = new System.Drawing.Size(323, 39);
			((System.ComponentModel.ISupportInitialize)(this.picTaskCount)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox picTaskCount;
		private System.Windows.Forms.ProgressBar pbrTask;
		private System.Windows.Forms.ComboBox cmbStatus;
	}
}
