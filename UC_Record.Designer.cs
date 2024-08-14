namespace StopWatch
{
    partial class UC_Record
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
            this.LblRecord = new System.Windows.Forms.Label();
            this.LblNum = new System.Windows.Forms.Label();
            this.LblRecordD = new System.Windows.Forms.Label();
            this.PicFlag = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRecord
            // 
            this.LblRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRecord.AutoSize = true;
            this.LblRecord.Location = new System.Drawing.Point(266, 7);
            this.LblRecord.Name = "LblRecord";
            this.LblRecord.Size = new System.Drawing.Size(72, 21);
            this.LblRecord.TabIndex = 0;
            this.LblRecord.Text = "00:00:00";
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNum.Location = new System.Drawing.Point(58, 7);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(25, 21);
            this.LblNum.TabIndex = 0;
            this.LblNum.Text = "01";
            // 
            // LblRecordD
            // 
            this.LblRecordD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblRecordD.AutoSize = true;
            this.LblRecordD.ForeColor = System.Drawing.Color.DimGray;
            this.LblRecordD.Location = new System.Drawing.Point(136, 7);
            this.LblRecordD.Name = "LblRecordD";
            this.LblRecordD.Size = new System.Drawing.Size(83, 21);
            this.LblRecordD.TabIndex = 0;
            this.LblRecordD.Text = "+00:00:00";
            // 
            // PicFlag
            // 
            this.PicFlag.Image = global::StopWatch.Properties.Resources.flag;
            this.PicFlag.Location = new System.Drawing.Point(35, 4);
            this.PicFlag.Name = "PicFlag";
            this.PicFlag.Size = new System.Drawing.Size(25, 25);
            this.PicFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicFlag.TabIndex = 1;
            this.PicFlag.TabStop = false;
            // 
            // UC_Record
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.PicFlag);
            this.Controls.Add(this.LblRecordD);
            this.Controls.Add(this.LblRecord);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_Record";
            this.Size = new System.Drawing.Size(350, 35);
            ((System.ComponentModel.ISupportInitialize)(this.PicFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PicFlag;
        public System.Windows.Forms.Label LblRecord;
        public System.Windows.Forms.Label LblNum;
        public System.Windows.Forms.Label LblRecordD;
    }
}
