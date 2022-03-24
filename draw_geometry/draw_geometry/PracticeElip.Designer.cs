namespace draw_geometry
{
    partial class PracticeElip
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
            this.picView = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBlue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // picView
            // 
            this.picView.Location = new System.Drawing.Point(200, 12);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(400, 400);
            this.picView.TabIndex = 5;
            this.picView.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDraw);
            this.groupBox2.Location = new System.Drawing.Point(12, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 57);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(78, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(9, 19);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(63, 23);
            this.btnDraw.TabIndex = 2;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tọa độ tâm";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(27, 49);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(121, 20);
            this.txtY.TabIndex = 4;
            this.txtY.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "y:";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(27, 23);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(121, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRy);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtRx);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(11, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(160, 86);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bán kính";
            // 
            // txtRy
            // 
            this.txtRy.Location = new System.Drawing.Point(27, 49);
            this.txtRy.Name = "txtRy";
            this.txtRy.Size = new System.Drawing.Size(121, 20);
            this.txtRy.TabIndex = 4;
            this.txtRy.Text = "150";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "y:";
            // 
            // txtRx
            // 
            this.txtRx.Location = new System.Drawing.Point(27, 23);
            this.txtRx.Name = "txtRx";
            this.txtRx.Size = new System.Drawing.Size(121, 20);
            this.txtRx.TabIndex = 4;
            this.txtRx.Text = "180";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "x:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBlue);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.txtGreen);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtRed);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(11, 225);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(160, 107);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Màu sắc";
            // 
            // txtGreen
            // 
            this.txtGreen.Location = new System.Drawing.Point(43, 49);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(105, 20);
            this.txtGreen.TabIndex = 4;
            this.txtGreen.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Green";
            // 
            // txtRed
            // 
            this.txtRed.Location = new System.Drawing.Point(43, 23);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(105, 20);
            this.txtRed.TabIndex = 4;
            this.txtRed.Text = "255";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Red:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Blue:";
            // 
            // txtBlue
            // 
            this.txtBlue.Location = new System.Drawing.Point(43, 75);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(105, 20);
            this.txtBlue.TabIndex = 4;
            this.txtBlue.Text = "0";
            // 
            // PracticeElip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 427);
            this.Controls.Add(this.picView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "PracticeElip";
            this.Text = "PracticeElip";
            this.Load += new System.EventHandler(this.PracticeElip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.Label label7;
    }
}