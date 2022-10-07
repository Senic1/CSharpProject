namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.rdbPorabola = new System.Windows.Forms.RadioButton();
            this.rdbsin = new System.Windows.Forms.RadioButton();
            this.rdbgiperbola = new System.Windows.Forms.RadioButton();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdblinstep = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(57, 139);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 35);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "СТАРТ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // rdbPorabola
            // 
            this.rdbPorabola.AutoSize = true;
            this.rdbPorabola.Checked = true;
            this.rdbPorabola.Location = new System.Drawing.Point(10, 19);
            this.rdbPorabola.Name = "rdbPorabola";
            this.rdbPorabola.Size = new System.Drawing.Size(75, 17);
            this.rdbPorabola.TabIndex = 1;
            this.rdbPorabola.TabStop = true;
            this.rdbPorabola.Text = "Парабола";
            this.rdbPorabola.UseVisualStyleBackColor = true;
            // 
            // rdbsin
            // 
            this.rdbsin.AutoSize = true;
            this.rdbsin.Location = new System.Drawing.Point(10, 42);
            this.rdbsin.Name = "rdbsin";
            this.rdbsin.Size = new System.Drawing.Size(149, 17);
            this.rdbsin.TabIndex = 2;
            this.rdbsin.Text = "Синусоида/косинусоида";
            this.rdbsin.UseVisualStyleBackColor = true;
            // 
            // rdbgiperbola
            // 
            this.rdbgiperbola.AutoSize = true;
            this.rdbgiperbola.Location = new System.Drawing.Point(10, 65);
            this.rdbgiperbola.Name = "rdbgiperbola";
            this.rdbgiperbola.Size = new System.Drawing.Size(79, 17);
            this.rdbgiperbola.TabIndex = 3;
            this.rdbgiperbola.Text = "Гипербола";
            this.rdbgiperbola.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rdblinstep);
            this.groupBox.Controls.Add(this.rdbgiperbola);
            this.groupBox.Controls.Add(this.rdbPorabola);
            this.groupBox.Controls.Add(this.rdbsin);
            this.groupBox.Location = new System.Drawing.Point(12, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 114);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Выберите функцию";
            // 
            // rdblinstep
            // 
            this.rdblinstep.AutoSize = true;
            this.rdblinstep.Location = new System.Drawing.Point(10, 87);
            this.rdblinstep.Name = "rdblinstep";
            this.rdblinstep.Size = new System.Drawing.Size(79, 17);
            this.rdblinstep.TabIndex = 5;
            this.rdblinstep.Text = "Степенная";
            this.rdblinstep.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 186);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Графики функций";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdbPorabola;
        private System.Windows.Forms.RadioButton rdbsin;
        private System.Windows.Forms.RadioButton rdbgiperbola;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton rdblinstep;
    }
}

