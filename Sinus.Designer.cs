namespace WindowsFormsApp1
{
    partial class Sinus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sinus));
            this.lblA = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.nudA = new System.Windows.Forms.NumericUpDown();
            this.nudK = new System.Windows.Forms.NumericUpDown();
            this.nudB = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBuild = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picSinus = new System.Windows.Forms.PictureBox();
            this.grbox = new System.Windows.Forms.GroupBox();
            this.rdnCos = new System.Windows.Forms.RadioButton();
            this.rdnSin = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinus)).BeginInit();
            this.grbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(43, 175);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(16, 13);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "a:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(43, 206);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(16, 13);
            this.lblK.TabIndex = 2;
            this.lblK.Text = "k:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(43, 239);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(16, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "b:";
            // 
            // nudA
            // 
            this.nudA.DecimalPlaces = 1;
            this.nudA.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudA.Location = new System.Drawing.Point(65, 173);
            this.nudA.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudA.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudA.Name = "nudA";
            this.nudA.Size = new System.Drawing.Size(120, 20);
            this.nudA.TabIndex = 4;
            this.nudA.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudK
            // 
            this.nudK.Cursor = System.Windows.Forms.Cursors.Default;
            this.nudK.DecimalPlaces = 1;
            this.nudK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudK.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudK.Location = new System.Drawing.Point(65, 206);
            this.nudK.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudK.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudK.Name = "nudK";
            this.nudK.Size = new System.Drawing.Size(120, 20);
            this.nudK.TabIndex = 5;
            this.nudK.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            // 
            // nudB
            // 
            this.nudB.DecimalPlaces = 1;
            this.nudB.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.nudB.Location = new System.Drawing.Point(65, 237);
            this.nudB.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudB.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.nudB.Name = "nudB";
            this.nudB.Size = new System.Drawing.Size(120, 20);
            this.nudB.TabIndex = 6;
            this.nudB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(61, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Назад";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(370, 173);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(95, 29);
            this.btnBuild.TabIndex = 8;
            this.btnBuild.Text = "Построить";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(380, 216);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 36);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "Задать цвета";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources.sin;
            this.pictureBox2.Location = new System.Drawing.Point(193, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(283, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // picSinus
            // 
            this.picSinus.BackColor = System.Drawing.SystemColors.Control;
            this.picSinus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSinus.Location = new System.Drawing.Point(26, 12);
            this.picSinus.Name = "picSinus";
            this.picSinus.Size = new System.Drawing.Size(439, 141);
            this.picSinus.TabIndex = 0;
            this.picSinus.TabStop = false;
            this.picSinus.Paint += new System.Windows.Forms.PaintEventHandler(this.picSinus_Paint);
            // 
            // grbox
            // 
            this.grbox.Controls.Add(this.rdnCos);
            this.grbox.Controls.Add(this.rdnSin);
            this.grbox.Location = new System.Drawing.Point(208, 175);
            this.grbox.Name = "grbox";
            this.grbox.Size = new System.Drawing.Size(141, 72);
            this.grbox.TabIndex = 11;
            this.grbox.TabStop = false;
            this.grbox.Text = "Выберите функцию";
            // 
            // rdnCos
            // 
            this.rdnCos.AutoSize = true;
            this.rdnCos.Location = new System.Drawing.Point(6, 42);
            this.rdnCos.Name = "rdnCos";
            this.rdnCos.Size = new System.Drawing.Size(91, 17);
            this.rdnCos.TabIndex = 1;
            this.rdnCos.Text = "Косинусоида";
            this.rdnCos.UseVisualStyleBackColor = true;
            // 
            // rdnSin
            // 
            this.rdnSin.AutoSize = true;
            this.rdnSin.Checked = true;
            this.rdnSin.Location = new System.Drawing.Point(6, 19);
            this.rdnSin.Name = "rdnSin";
            this.rdnSin.Size = new System.Drawing.Size(79, 17);
            this.rdnSin.TabIndex = 0;
            this.rdnSin.TabStop = true;
            this.rdnSin.Text = "Синусоида";
            this.rdnSin.UseVisualStyleBackColor = true;
            // 
            // Sinus
            // 
            this.AcceptButton = this.btnBuild;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(488, 364);
            this.Controls.Add(this.grbox);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnBuild);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.nudB);
            this.Controls.Add(this.nudK);
            this.Controls.Add(this.nudA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblK);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.picSinus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sinus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Синусоида/Косинусоида";
            ((System.ComponentModel.ISupportInitialize)(this.nudA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSinus)).EndInit();
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSinus;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.NumericUpDown nudA;
        private System.Windows.Forms.NumericUpDown nudK;
        private System.Windows.Forms.NumericUpDown nudB;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox grbox;
        private System.Windows.Forms.RadioButton rdnCos;
        private System.Windows.Forms.RadioButton rdnSin;
    }
}