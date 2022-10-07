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
    public partial class Sinus : Form
    {
        bool yes = false;//Если кнопка "СТАРТ" не нажата, то рисование невозможно
        Formcolor formcoloronform;
        Pen pen = new Pen(Color.Red, 2);//кисть для рисования графика
        public Sinus()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            yes = true;
            picSinus.Invalidate();
        }

        private void picSinus_Paint(object sender, PaintEventArgs e)
        {

            if (yes)
            {
                float a = (float)nudA.Value;
                float b = (float)nudB.Value;
                float k = (float)nudK.Value;
                //создание полотна для рисования
                Graphics polotno;
                polotno = e.Graphics;
                //начало координат в середине picturebox
                polotno.TranslateTransform(picSinus.Width / 2, picSinus.Height / 2);
                int x = picSinus.Width / 10;
                int y = picSinus.Height / 10;
                Pen mypen = new Pen(Color.Black, 1);
                // система координат
                polotno.DrawLine(mypen, -10 * x, 0, 10 * x, 0);
                polotno.DrawLine(mypen, 0, -10 * y, 0, 10 * y);
                //штрихи на системе координат
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, -5, picSinus.Width / 40 * i, 5, picSinus.Width / 40 * i);
                }
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, picSinus.Height / 5 * i, -5, picSinus.Height / 5 * i, 5);
                }
                if (rdnSin.Checked==true)
                {
                    
                    for (float i = (float)-10; i < 10; i += (float)0.1)


                    {
                        //построение синусоиды
                        float y1 = -(float)(a * Math.Sin(k * i + b));
                        float y2 = -(float)(a * Math.Sin(k * (i + 0.1) + b));
                        float x1 = (float)(picSinus.Width / 20 * i);
                        float x2 = (float)(picSinus.Width / 20 * (i + 0.1));
                        y1 = (float)(picSinus.Width / 40 * y1);
                        y2 = (float)(picSinus.Width / 40 * y2);
                        polotno.DrawLine(pen, x1, y1, x2, y2);
                        
                    }
                }
                if (rdnCos.Checked==true)
                {
                    for (float i = (float)-10; i < 10; i += (float)0.1)
                {
                        //построение косинусоиды
                        float y1 = -(float)(a * Math.Cos(k * i + b));
                        float y2 = -(float)(a * Math.Cos(k * (i + 0.1) + b));
                        float x1 = (float)(picSinus.Width / 20 * i);
                        float x2 = (float)(picSinus.Width / 20 * (i + 0.1));
                        y1 = (float)(picSinus.Width / 40 * y1);
                        y2 = (float)(picSinus.Width / 40 * y2);
                        polotno.DrawLine(pen, x1, y1, x2, y2);
                    }
                }  
            }
            


        }
    

        private void btnColor_Click(object sender, EventArgs e)
        {
            //окно с выбором цвета 
            if (yes)
            {

                formcoloronform = new Formcolor();
                formcoloronform.picbackcolor.BackColor = picSinus.BackColor;
                formcoloronform.picline.BackColor = pen.Color;//цвета из формы в форму с выбором цвета
                formcoloronform.ShowDialog();
              
                picSinus.BackColor = formcoloronform.picbackcolor.BackColor; 
                pen.Color = formcoloronform.picline.BackColor;//цвета из выбора цвета в форму    
                formcoloronform.Dispose();
                picSinus.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала постройте график", "Внимание", MessageBoxButtons.OK);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
