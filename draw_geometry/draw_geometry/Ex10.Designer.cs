namespace draw_geometry
{
    partial class Ex10
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblScale = new System.Windows.Forms.Label();
            this.trackScale = new System.Windows.Forms.TrackBar();
            this.rdbRotateCounterclockwise = new System.Windows.Forms.RadioButton();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.rdbRotateClockwise = new System.Windows.Forms.RadioButton();
            this.picView = new System.Windows.Forms.PictureBox();
            this.timeRun = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdbRotateCounterclockwise);
            this.panel1.Controls.Add(this.rdbDefault);
            this.panel1.Controls.Add(this.rdbRotateClockwise);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 578);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblScale);
            this.panel2.Controls.Add(this.trackScale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 418);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 160);
            this.panel2.TabIndex = 3;
            // 
            // lblScale
            // 
            this.lblScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScale.Location = new System.Drawing.Point(10, 10);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(235, 23);
            this.lblScale.TabIndex = 2;
            this.lblScale.Text = "label1";
            this.lblScale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackScale
            // 
            this.trackScale.Location = new System.Drawing.Point(10, 41);
            this.trackScale.Minimum = 1;
            this.trackScale.Name = "trackScale";
            this.trackScale.Size = new System.Drawing.Size(235, 45);
            this.trackScale.TabIndex = 1;
            this.trackScale.Value = 1;
            this.trackScale.ValueChanged += new System.EventHandler(this.trackScale_ValueChanged);
            // 
            // rdbRotateCounterclockwise
            // 
            this.rdbRotateCounterclockwise.AutoSize = true;
            this.rdbRotateCounterclockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRotateCounterclockwise.Location = new System.Drawing.Point(12, 100);
            this.rdbRotateCounterclockwise.Name = "rdbRotateCounterclockwise";
            this.rdbRotateCounterclockwise.Size = new System.Drawing.Size(235, 28);
            this.rdbRotateCounterclockwise.TabIndex = 0;
            this.rdbRotateCounterclockwise.Text = "Rotate Counterclockwise";
            this.rdbRotateCounterclockwise.UseVisualStyleBackColor = true;
            this.rdbRotateCounterclockwise.CheckedChanged += new System.EventHandler(this.rdbRotateCounterclockwise_CheckedChanged);
            // 
            // rdbDefault
            // 
            this.rdbDefault.AutoSize = true;
            this.rdbDefault.Checked = true;
            this.rdbDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDefault.Location = new System.Drawing.Point(12, 26);
            this.rdbDefault.Name = "rdbDefault";
            this.rdbDefault.Size = new System.Drawing.Size(85, 28);
            this.rdbDefault.TabIndex = 0;
            this.rdbDefault.TabStop = true;
            this.rdbDefault.Text = "Default";
            this.rdbDefault.UseVisualStyleBackColor = true;
            this.rdbDefault.CheckedChanged += new System.EventHandler(this.rdbDefault_CheckedChanged);
            // 
            // rdbRotateClockwise
            // 
            this.rdbRotateClockwise.AutoSize = true;
            this.rdbRotateClockwise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRotateClockwise.Location = new System.Drawing.Point(12, 63);
            this.rdbRotateClockwise.Name = "rdbRotateClockwise";
            this.rdbRotateClockwise.Size = new System.Drawing.Size(171, 28);
            this.rdbRotateClockwise.TabIndex = 0;
            this.rdbRotateClockwise.Text = "Rotate Clockwise";
            this.rdbRotateClockwise.UseVisualStyleBackColor = true;
            this.rdbRotateClockwise.CheckedChanged += new System.EventHandler(this.rdbRotateClockwise_CheckedChanged);
            // 
            // picView
            // 
            this.picView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picView.Location = new System.Drawing.Point(254, 0);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(620, 578);
            this.picView.TabIndex = 14;
            this.picView.TabStop = false;
            this.picView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picView_MouseClick);
            // 
            // timeRun
            // 
            this.timeRun.Interval = 50;
            this.timeRun.Tick += new System.EventHandler(this.timeRun_Tick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(0, 115);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(254, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Ex10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 578);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.panel1);
            this.Name = "Ex10";
            this.Text = "Ex10";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ex10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.TrackBar trackScale;
        private System.Windows.Forms.RadioButton rdbRotateCounterclockwise;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.RadioButton rdbRotateClockwise;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timeRun;
        private System.Windows.Forms.Button btnRefresh;

    }
}