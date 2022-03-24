namespace draw_geometry
{
    partial class Ex7
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblScale = new System.Windows.Forms.Label();
            this.trackScale = new System.Windows.Forms.TrackBar();
            this.rdbHaveMoon = new System.Windows.Forms.RadioButton();
            this.rdbDefault = new System.Windows.Forms.RadioButton();
            this.rdbRotate = new System.Windows.Forms.RadioButton();
            this.picView = new System.Windows.Forms.PictureBox();
            this.timeRun = new System.Windows.Forms.Timer(this.components);
            this.timerMoon = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.Controls.Add(this.rdbHaveMoon);
            this.panel1.Controls.Add(this.rdbDefault);
            this.panel1.Controls.Add(this.rdbRotate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 590);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.lblScale);
            this.panel2.Controls.Add(this.trackScale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 430);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 160);
            this.panel2.TabIndex = 3;
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
            // rdbHaveMoon
            // 
            this.rdbHaveMoon.AutoSize = true;
            this.rdbHaveMoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHaveMoon.Location = new System.Drawing.Point(12, 100);
            this.rdbHaveMoon.Name = "rdbHaveMoon";
            this.rdbHaveMoon.Size = new System.Drawing.Size(126, 28);
            this.rdbHaveMoon.TabIndex = 0;
            this.rdbHaveMoon.Text = "Have Moon";
            this.rdbHaveMoon.UseVisualStyleBackColor = true;
            this.rdbHaveMoon.CheckedChanged += new System.EventHandler(this.rdbHaveMoon_CheckedChanged);
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
            // rdbRotate
            // 
            this.rdbRotate.AutoSize = true;
            this.rdbRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRotate.Location = new System.Drawing.Point(12, 63);
            this.rdbRotate.Name = "rdbRotate";
            this.rdbRotate.Size = new System.Drawing.Size(81, 28);
            this.rdbRotate.TabIndex = 0;
            this.rdbRotate.Text = "Rotate";
            this.rdbRotate.UseVisualStyleBackColor = true;
            this.rdbRotate.CheckedChanged += new System.EventHandler(this.rdbRotate_CheckedChanged);
            // 
            // picView
            // 
            this.picView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picView.Location = new System.Drawing.Point(254, 0);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(479, 590);
            this.picView.TabIndex = 16;
            this.picView.TabStop = false;
            this.picView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picView_MouseClick);
            // 
            // timeRun
            // 
            this.timeRun.Interval = 50;
            this.timeRun.Tick += new System.EventHandler(this.timeRun_Tick);
            // 
            // timerMoon
            // 
            this.timerMoon.Interval = 50;
            this.timerMoon.Tick += new System.EventHandler(this.timerMoon_Tick);
            // 
            // Ex7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 590);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.panel1);
            this.Name = "Ex7";
            this.Text = "Ex4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ex7_Load);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.TrackBar trackScale;
        private System.Windows.Forms.RadioButton rdbHaveMoon;
        private System.Windows.Forms.RadioButton rdbDefault;
        private System.Windows.Forms.RadioButton rdbRotate;
        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.Timer timeRun;
        private System.Windows.Forms.Timer timerMoon;

    }
}