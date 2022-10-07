namespace WindowsFormsApp1
{
    partial class linstep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(linstep));
            this.pic = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdb2 = new System.Windows.Forms.RadioButton();
            this.rdb3 = new System.Windows.Forms.RadioButton();
            this.rdb1 = new System.Windows.Forms.RadioButton();
            this.rdb4 = new System.Windows.Forms.RadioButton();
            this.btnexit = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pic.Location = new System.Drawing.Point(272, 32);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(340, 357);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 167);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(107, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Построить";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdb2
            // 
            this.rdb2.AutoSize = true;
            this.rdb2.Location = new System.Drawing.Point(21, 47);
            this.rdb2.Name = "rdb2";
            this.rdb2.Size = new System.Drawing.Size(84, 17);
            this.rdb2.TabIndex = 5;
            this.rdb2.Text = "Квадрат (x²)";
            this.rdb2.UseVisualStyleBackColor = true;
            // 
            // rdb3
            // 
            this.rdb3.AutoSize = true;
            this.rdb3.Location = new System.Drawing.Point(21, 85);
            this.rdb3.Name = "rdb3";
            this.rdb3.Size = new System.Drawing.Size(60, 17);
            this.rdb3.TabIndex = 6;
            this.rdb3.Text = "Куб (x³)";
            this.rdb3.UseVisualStyleBackColor = true;
            // 
            // rdb1
            // 
            this.rdb1.AutoSize = true;
            this.rdb1.Checked = true;
            this.rdb1.Location = new System.Drawing.Point(21, 12);
            this.rdb1.Name = "rdb1";
            this.rdb1.Size = new System.Drawing.Size(104, 17);
            this.rdb1.TabIndex = 7;
            this.rdb1.TabStop = true;
            this.rdb1.Text = "1-ая степень (x)";
            this.rdb1.UseVisualStyleBackColor = true;
            // 
            // rdb4
            // 
            this.rdb4.AutoSize = true;
            this.rdb4.Location = new System.Drawing.Point(20, 121);
            this.rdb4.Name = "rdb4";
            this.rdb4.Size = new System.Drawing.Size(116, 17);
            this.rdb4.TabIndex = 8;
            this.rdb4.Text = "4-ая степень (x^4)";
            this.rdb4.UseVisualStyleBackColor = true;
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(20, 366);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "Назад";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(21, 232);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(104, 37);
            this.btncolor.TabIndex = 10;
            this.btncolor.Text = "Задать цвет";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // linstep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 419);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.rdb4);
            this.Controls.Add(this.rdb1);
            this.Controls.Add(this.rdb3);
            this.Controls.Add(this.rdb2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "linstep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Степень";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdb2;
        private System.Windows.Forms.RadioButton rdb3;
        private System.Windows.Forms.RadioButton rdb1;
        private System.Windows.Forms.RadioButton rdb4;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btncolor;
    }
}