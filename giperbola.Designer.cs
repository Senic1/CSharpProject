namespace WindowsFormsApp1
{
    partial class giperbola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giperbola));
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picGiperbola = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiperbola)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(12, 108);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(102, 32);
            this.btnBuild.TabIndex = 1;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 146);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(102, 30);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Задать цвет";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 338);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(65, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(12, 23);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 4;
            this.lblA.Text = "a:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(12, 62);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 13);
            this.lblB.TabIndex = 5;
            this.lblB.Text = "b:";
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 2;
            this.nudA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudA.Location = new System.Drawing.Point(34, 23);
            this.nudA.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudA.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(58, 20);
            this.nudA.TabIndex = 6;
            this.nudA.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 2;
            this.nudB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudB.Location = new System.Drawing.Point(34, 60);
            this.nudB.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudB.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(58, 20);
            this.nudB.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.giperbola;
            this.pictureBox2.Location = new System.Drawing.Point(12, 196);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // picGiperbola
            // 
            this.picGiperbola.BackColor = System.Drawing.SystemColors.Control;
            this.picGiperbola.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGiperbola.Location = new System.Drawing.Point(204, 23);
            this.picGiperbola.Name = "picGiperbola";
            this.picGiperbola.Size = new System.Drawing.Size(354, 327);
            this.picGiperbola.TabIndex = 0;
            this.picGiperbola.TabStop = false;
            this.picGiperbola.Paint += new System.Windows.Forms.PaintEventHandler(this.picGiperbola_Paint);
            // 
            // giperbola
            // 
            this.AcceptButton = this.btnBuild;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(585, 373);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.picGiperbola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "giperbola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гипербола";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGiperbola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGiperbola;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}