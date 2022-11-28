namespace LifeGameWinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDisCur = new System.Windows.Forms.Label();
            this.lblResCur = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tbDensity = new System.Windows.Forms.TrackBar();
            this.label_Density = new System.Windows.Forms.Label();
            this.tB_resolution = new System.Windows.Forms.TrackBar();
            this.label_resolution = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitContainer1.Panel1.Controls.Add(this.lblDisCur);
            this.splitContainer1.Panel1.Controls.Add(this.lblResCur);
            this.splitContainer1.Panel1.Controls.Add(this.btnStop);
            this.splitContainer1.Panel1.Controls.Add(this.btnStart);
            this.splitContainer1.Panel1.Controls.Add(this.tbDensity);
            this.splitContainer1.Panel1.Controls.Add(this.label_Density);
            this.splitContainer1.Panel1.Controls.Add(this.tB_resolution);
            this.splitContainer1.Panel1.Controls.Add(this.label_resolution);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(991, 505);
            this.splitContainer1.SplitterDistance = 205;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblDisCur
            // 
            this.lblDisCur.AutoSize = true;
            this.lblDisCur.Location = new System.Drawing.Point(130, 449);
            this.lblDisCur.Name = "lblDisCur";
            this.lblDisCur.Size = new System.Drawing.Size(17, 20);
            this.lblDisCur.TabIndex = 8;
            this.lblDisCur.Text = "2";
            // 
            // lblResCur
            // 
            this.lblResCur.AutoSize = true;
            this.lblResCur.Location = new System.Drawing.Point(42, 449);
            this.lblResCur.Name = "lblResCur";
            this.lblResCur.Size = new System.Drawing.Size(17, 20);
            this.lblResCur.TabIndex = 7;
            this.lblResCur.Text = "3";
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStop.Location = new System.Drawing.Point(26, 77);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(26, 22);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tbDensity
            // 
            this.tbDensity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbDensity.Location = new System.Drawing.Point(118, 164);
            this.tbDensity.Maximum = 25;
            this.tbDensity.Minimum = 1;
            this.tbDensity.Name = "tbDensity";
            this.tbDensity.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tbDensity.Size = new System.Drawing.Size(56, 285);
            this.tbDensity.TabIndex = 4;
            this.tbDensity.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbDensity.Value = 2;
            this.tbDensity.ValueChanged += new System.EventHandler(this.tbDensity_ValueChanged);
            // 
            // label_Density
            // 
            this.label_Density.AutoSize = true;
            this.label_Density.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Density.Location = new System.Drawing.Point(104, 141);
            this.label_Density.Name = "label_Density";
            this.label_Density.Size = new System.Drawing.Size(85, 20);
            this.label_Density.TabIndex = 6;
            this.label_Density.Text = "Плотность";
            // 
            // tB_resolution
            // 
            this.tB_resolution.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tB_resolution.Location = new System.Drawing.Point(28, 164);
            this.tB_resolution.Maximum = 25;
            this.tB_resolution.Minimum = 3;
            this.tB_resolution.Name = "tB_resolution";
            this.tB_resolution.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tB_resolution.Size = new System.Drawing.Size(56, 285);
            this.tB_resolution.TabIndex = 3;
            this.tB_resolution.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tB_resolution.Value = 3;
            this.tB_resolution.ValueChanged += new System.EventHandler(this.tB_resolution_ValueChanged);
            // 
            // label_resolution
            // 
            this.label_resolution.AutoSize = true;
            this.label_resolution.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_resolution.Location = new System.Drawing.Point(5, 141);
            this.label_resolution.Name = "label_resolution";
            this.label_resolution.Size = new System.Drawing.Size(97, 20);
            this.label_resolution.TabIndex = 5;
            this.label_resolution.Text = "Разрешение";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 501);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 505);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Игра \"Жизнь\" Поколение 0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbDensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tB_resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnStop;
        private Button btnStart;
        private TrackBar tbDensity;
        private Label label_Density;
        private TrackBar tB_resolution;
        private Label label_resolution;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private Label lblDisCur;
        private Label lblResCur;
    }
}