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
    public partial class giperbola : Form
    {
        bool yes = false;//Если кнопка "СТАРТ" не нажата, то рисование невозможно
        Formcolor formcoloronform;
        Pen mypen2 = new Pen(Color.Red, 3);//кисть для рисования графика
        public giperbola()
        {
            InitializeComponent();
        }

        private void btnBuild_Click(object sender, EventArgs e)
        {
            yes = true;
            picGiperbola.Invalidate();
        }
        private void picGiperbola_Paint(object sender, PaintEventArgs e)
        {
            if (yes)
            {
                float a = (float)nudA.Value;
                float b = (float)nudB.Value;
                //создание полотна для рисования       
                Graphics polotno;
                polotno = e.Graphics;
                //начало координат в середине picturebox
                polotno.TranslateTransform(picGiperbola.Width / 2, picGiperbola.Height / 2);
                // система координат
                int x = picGiperbola.Width / 10;
                int y = picGiperbola.Height / 10;
                Pen mypen = new Pen(Color.Black, 1);
                polotno.DrawLine(mypen, -10 * x, 0, 10 * x, 0);
                polotno.DrawLine(mypen, 0, -10 * y, 0, 10 * y);
                //штрихи на системе координат
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, -7, picGiperbola.Width / 20 * i, 7, picGiperbola.Width / 20 * i);
                }
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, picGiperbola.Height / 20 * i, -7, picGiperbola.Height / 20 * i, 7);
                }
                //построение гиперболы. Разрыв графика происходит в точке x = -b, а если x(shag,i) -
                // - движется к нулю, то у "y" получаются слишком большие значения
                for (float shag = (float)-10; shag <=-b-0.05; shag += (float)0.05)
                { 
                    //построение гиперболы до x = -b
                        float y1 = -(float)(a / (shag + b));
                        float y2 = -(float)(a / ((shag + 0.05) + b));
                        float x1 = (float)(picGiperbola.Width / 20 * shag);
                        float x2 = (float)(picGiperbola.Width / 20 * (shag + 0.05));
                        y1 = (float)(picGiperbola.Height / 20 * y1);
                        y2 = (float)(picGiperbola.Height / 20 * y2);
                        polotno.DrawLine(mypen2, x1, y1, x2, y2);
                }
                for (float i = (float)-b+(float)0.05; i <= 10; i += (float)0.05)
                {
                    //построение гиперболы после x = -b
                        float y1 = -(float)(a / (i + b));
                        float y2 = -(float)(a / ((i + 0.05) + b));
                        float x1 = (float)(picGiperbola.Width / 20 * i);
                        float x2 = (float)(picGiperbola.Width / 20 * (i + 0.05));
                        y1 = (float)(picGiperbola.Height / 20 * y1);
                        y2 = (float)(picGiperbola.Height / 20 * y2);
                        polotno.DrawLine(mypen2, x1, y1, x2, y2);                
                }
            }                 
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            //окно с выбором цвета 
            if (yes)
            {

                formcoloronform = new Formcolor();
                formcoloronform.picbackcolor.BackColor = picGiperbola.BackColor;
                formcoloronform.picline.BackColor = mypen2.Color;//цвета из формы в форму с выбором цвета
                formcoloronform.ShowDialog();
              
                picGiperbola.BackColor = formcoloronform.picbackcolor.BackColor;
                mypen2.Color = formcoloronform.picline.BackColor;//цвета из выбора цвета в форму
                formcoloronform.Dispose();
                picGiperbola.Invalidate();
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
  

