using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class linstep : Form
    {
        bool yes = false;
        Formcolor formcoloronform;
        Pen mypen2 = new Pen(Color.Red,3);
        public linstep()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (yes)
            {
                //создание полотна для рисования       
                Graphics polotno;
                polotno = e.Graphics;
                //начало координат в середине picturebox
                polotno.TranslateTransform(pic.Width / 2, pic.Height / 2);
                // система координат
                int x = pic.Width / 10;
                int y = pic.Height / 10;
                Pen mypen = new Pen(Color.Black, 1);
                polotno.DrawLine(mypen, -10 * x, 0, 10 * x, 0);
                polotno.DrawLine(mypen, 0, -10 * y, 0, 10 * y);
                //штрихи на системе координат
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, -7, pic.Width / 20 * i, 7, pic.Width / 20 * i);
                }
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, pic.Height / 20 * i, -7, pic.Height / 20 * i, 7);
                }
                
                if (rdb3.Checked)
                {   
                for (float shag = (float)-10; shag <= 10; shag += (float)0.05)
                {
                    //построение степенной функции x³
                    float y1 = -(float)(shag * shag * shag);
                    float y2 = -(float)((shag + 0.05) * (shag + 0.05) * (shag + 0.05));
                    float x1 = (float)(pic.Width / 20 * shag);
                    float x2 = (float)(pic.Width / 20 * (shag + 0.05));
                    y1 = (float)(pic.Height / 20 * y1);
                    y2 = (float)(pic.Height / 20 * y2);
                    polotno.DrawLine(mypen2, x1, y1, x2, y2);
                }
            }
                else
                {
                    if (rdb2.Checked)
                    {
                        for (float shag = (float)-10; shag <= 10; shag += (float)0.05)
                        {
                            //построение степенной функции x²
                            float y1 = -(float)(shag * shag);
                            float y2 = -(float)((shag + 0.05) * (shag + 0.05));
                            float x1 = (float)(pic.Width / 20 * shag);
                            float x2 = (float)(pic.Width / 20 * (shag + 0.05));
                            y1 = (float)(pic.Height / 20 * y1);
                            y2 = (float)(pic.Height / 20 * y2);
                            polotno.DrawLine(mypen2, x1, y1, x2, y2);
                        }
                    }
                    else
                    {
                        if (rdb1.Checked)
                        {

                            for (float shag = (float)-10; shag <= 10; shag += (float)0.05)
                            {
                                //построение степенной функции x
                                float y1 = -(float)(shag);
                                float y2 = -(float)((shag + 0.05));
                                float x1 = (float)(pic.Width / 20 * shag);
                                float x2 = (float)(pic.Width / 20 * (shag + 0.05));
                                y1 = (float)(pic.Height / 20 * y1);
                                y2 = (float)(pic.Height / 20 * y2);
                                polotno.DrawLine(mypen2, x1, y1, x2, y2);
                            }

                        }
                        else
                        {
                            if (rdb4.Checked)
                            {
                                for (float shag = (float)-10; shag <= 10; shag += (float)0.05)
                                {
                                    //построение степенной функции x^4
                                    float y1 = -(float)(shag * shag*shag*shag);
                                    float y2 = -(float)((shag + 0.05) * (shag + 0.05)* (shag + 0.05)* (shag + 0.05));
                                    float x1 = (float)(pic.Width / 20 * shag);
                                    float x2 = (float)(pic.Width / 20 * (shag + 0.05));
                                    y1 = (float)(pic.Height / 20 * y1);
                                    y2 = (float)(pic.Height / 20 * y2);
                                    polotno.DrawLine(mypen2, x1, y1, x2, y2);
                                }
                            }
                        }
                    }
                }
            }
       }
        private void btnStart_Click(object sender, EventArgs e)
        {
            yes = true;
            pic.Invalidate();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            //окно с выбором цвета 
            if (yes)
            {

                formcoloronform = new Formcolor();
                formcoloronform.picbackcolor.BackColor = pic.BackColor;
                formcoloronform.picline.BackColor = mypen2.Color;//цвета из формы в форму с выбором цвета
                formcoloronform.ShowDialog();
                
                pic.BackColor = formcoloronform.picbackcolor.BackColor;
                mypen2.Color = formcoloronform.picline.BackColor;//цвета из выбора цвета в форму
                formcoloronform.Dispose();
                pic.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала постройте график", "Внимание", MessageBoxButtons.OK);
            }
        }
    }
}
