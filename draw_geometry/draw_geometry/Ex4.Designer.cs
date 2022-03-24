namespace draw_geometry
{
    partial class Ex4
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
            ((System.ComponentModel.ISupportInitialize)(this.picView)).BeginInit();
            this.SuspendLayout();
            // 
            // picView
            // 
            this.picView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picView.Location = new System.Drawing.Point(0, 0);
            this.picView.Name = "picView";
            this.picView.Size = new System.Drawing.Size(481, 427);
            this.picView.TabIndex = 8;
            this.picView.TabStop = false;
            this.picView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picView_MouseClick);
            // 
            // Ex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 427);
            this.Controls.Add(this.picView);
            this.Name = "Ex4";
            this.Text = "Ex4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ex4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picView;
    }
}