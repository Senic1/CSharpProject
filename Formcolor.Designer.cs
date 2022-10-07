namespace WindowsFormsApp1
{
    partial class Formcolor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formcolor));
            this.lblbackcolor = new System.Windows.Forms.Label();
            this.lblline = new System.Windows.Forms.Label();
            this.picbackcolor = new System.Windows.Forms.PictureBox();
            this.picline = new System.Windows.Forms.PictureBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.cd = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picbackcolor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picline)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbackcolor
            // 
            this.lblbackcolor.AutoSize = true;
            this.lblbackcolor.Location = new System.Drawing.Point(32, 22);
            this.lblbackcolor.Name = "lblbackcolor";
            this.lblbackcolor.Size = new System.Drawing.Size(118, 13);
            this.lblbackcolor.TabIndex = 0;
            this.lblbackcolor.Text = "Выберите цвет фона: ";
            this.lblbackcolor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblline
            // 
            this.lblline.AutoSize = true;
            this.lblline.Location = new System.Drawing.Point(32, 53);
            this.lblline.Name = "lblline";
            this.lblline.Size = new System.Drawing.Size(122, 13);
            this.lblline.TabIndex = 1;
            this.lblline.Text = "Выберите цвет линии: ";
            // 
            // picbackcolor
            // 
            this.picbackcolor.BackColor = System.Drawing.Color.White;
            this.picbackcolor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picbackcolor.Location = new System.Drawing.Point(156, 12);
            this.picbackcolor.Name = "picbackcolor";
            this.picbackcolor.Size = new System.Drawing.Size(29, 25);
            this.picbackcolor.TabIndex = 2;
            this.picbackcolor.TabStop = false;
            this.picbackcolor.Click += new System.EventHandler(this.picbackcolor_Click);
            // 
            // picline
            // 
            this.picline.BackColor = System.Drawing.Color.Red;
            this.picline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picline.Location = new System.Drawing.Point(156, 43);
            this.picline.Name = "picline";
            this.picline.Size = new System.Drawing.Size(29, 27);
            this.picline.TabIndex = 3;
            this.picline.TabStop = false;
            this.picline.Click += new System.EventHandler(this.picline_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(95, 77);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(59, 27);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Formcolor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 116);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.picline);
            this.Controls.Add(this.picbackcolor);
            this.Controls.Add(this.lblline);
            this.Controls.Add(this.lblbackcolor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Formcolor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор цвета";
            this.Load += new System.EventHandler(this.Formcolor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbackcolor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbackcolor;
        private System.Windows.Forms.Label lblline;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ColorDialog cd;
        public System.Windows.Forms.PictureBox picbackcolor;
        public System.Windows.Forms.PictureBox picline;
    }
}