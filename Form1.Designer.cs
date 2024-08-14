namespace StopWatch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlBtn = new System.Windows.Forms.Panel();
            this.pnlStopWatch = new System.Windows.Forms.Panel();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.LblTimer = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BtnMin = new System.Windows.Forms.Button();
            this.BtnMax = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnPlay = new BahmanButton.BahmanButtonControl();
            this.BtnStop = new BahmanButton.BahmanButtonControl();
            this.PnlBtn.SuspendLayout();
            this.pnlStopWatch.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBtn
            // 
            this.PnlBtn.Controls.Add(this.BtnPlay);
            this.PnlBtn.Controls.Add(this.BtnStop);
            this.PnlBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBtn.Location = new System.Drawing.Point(15, 478);
            this.PnlBtn.Margin = new System.Windows.Forms.Padding(0);
            this.PnlBtn.Name = "PnlBtn";
            this.PnlBtn.Size = new System.Drawing.Size(420, 117);
            this.PnlBtn.TabIndex = 0;
            // 
            // pnlStopWatch
            // 
            this.pnlStopWatch.Controls.Add(this.LblTimer);
            this.pnlStopWatch.Controls.Add(this.pnlOut);
            this.pnlStopWatch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStopWatch.Location = new System.Drawing.Point(15, 5);
            this.pnlStopWatch.Margin = new System.Windows.Forms.Padding(0);
            this.pnlStopWatch.Name = "pnlStopWatch";
            this.pnlStopWatch.Size = new System.Drawing.Size(420, 218);
            this.pnlStopWatch.TabIndex = 1;
            // 
            // pnlOut
            // 
            this.pnlOut.Controls.Add(this.BtnMin);
            this.pnlOut.Controls.Add(this.BtnMax);
            this.pnlOut.Controls.Add(this.BtnExit);
            this.pnlOut.Location = new System.Drawing.Point(275, -21);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(181, 57);
            this.pnlOut.TabIndex = 0;
            // 
            // LblTimer
            // 
            this.LblTimer.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblTimer.AutoSize = true;
            this.LblTimer.Font = new System.Drawing.Font("Segoe UI", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblTimer.Location = new System.Drawing.Point(59, 128);
            this.LblTimer.Name = "LblTimer";
            this.LblTimer.Size = new System.Drawing.Size(308, 89);
            this.LblTimer.TabIndex = 1;
            this.LblTimer.Text = "00:00:00";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 223);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 255);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BtnMin
            // 
            this.BtnMin.FlatAppearance.BorderSize = 0;
            this.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMin.Image = global::StopWatch.Properties.Resources.min;
            this.BtnMin.Location = new System.Drawing.Point(11, 20);
            this.BtnMin.Name = "BtnMin";
            this.BtnMin.Size = new System.Drawing.Size(44, 34);
            this.BtnMin.TabIndex = 0;
            this.BtnMin.UseVisualStyleBackColor = true;
            this.BtnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // BtnMax
            // 
            this.BtnMax.FlatAppearance.BorderSize = 0;
            this.BtnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMax.Image = global::StopWatch.Properties.Resources.max;
            this.BtnMax.Location = new System.Drawing.Point(59, 20);
            this.BtnMax.Name = "BtnMax";
            this.BtnMax.Size = new System.Drawing.Size(44, 34);
            this.BtnMax.TabIndex = 0;
            this.BtnMax.UseVisualStyleBackColor = true;
            this.BtnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Image = global::StopWatch.Properties.Resources.x;
            this.BtnExit.Location = new System.Drawing.Point(105, 20);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(41, 34);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPlay.BackColor = System.Drawing.Color.LightGray;
            this.BtnPlay.BackgroundColor = System.Drawing.Color.LightGray;
            this.BtnPlay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnPlay.BorderRadius = 45;
            this.BtnPlay.BorderSize = 1;
            this.BtnPlay.FlatAppearance.BorderSize = 0;
            this.BtnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlay.ForeColor = System.Drawing.Color.White;
            this.BtnPlay.Image = global::StopWatch.Properties.Resources.play;
            this.BtnPlay.Location = new System.Drawing.Point(216, 0);
            this.BtnPlay.Margin = new System.Windows.Forms.Padding(0);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(93, 94);
            this.BtnPlay.TabIndex = 0;
            this.BtnPlay.Tag = "Play";
            this.BtnPlay.TextColor = System.Drawing.Color.White;
            this.BtnPlay.UseVisualStyleBackColor = false;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnStop
            // 
            this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnStop.BackColor = System.Drawing.Color.LightGray;
            this.BtnStop.BackgroundColor = System.Drawing.Color.LightGray;
            this.BtnStop.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.BtnStop.BorderRadius = 45;
            this.BtnStop.BorderSize = 1;
            this.BtnStop.FlatAppearance.BorderSize = 0;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Image = global::StopWatch.Properties.Resources.stop;
            this.BtnStop.Location = new System.Drawing.Point(114, 0);
            this.BtnStop.Margin = new System.Windows.Forms.Padding(0);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(93, 94);
            this.BtnStop.TabIndex = 0;
            this.BtnStop.Tag = "Stop";
            this.BtnStop.TextColor = System.Drawing.Color.White;
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlStopWatch);
            this.Controls.Add(this.PnlBtn);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.PnlBtn.ResumeLayout(false);
            this.pnlStopWatch.ResumeLayout(false);
            this.pnlStopWatch.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBtn;
        private BahmanButton.BahmanButtonControl BtnStop;
        private BahmanButton.BahmanButtonControl BtnPlay;
        private System.Windows.Forms.Panel pnlStopWatch;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Button BtnMin;
        private System.Windows.Forms.Button BtnMax;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Label LblTimer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer;
    }
}

