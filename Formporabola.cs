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
    public partial class Formporabola : Form
    {
        bool yes = false; //Если кнопка "СТАРТ" не нажата, то рисование невозможно
        Formcolor formcoloronform;
        Pen pen = new Pen(Color.Red, 3); //кисть для рисования графика
        public Formporabola()
        {
            InitializeComponent();
        }
        private void btnBuild_Click(object sender, EventArgs e)
        {
            yes = true;
            picPorabola.Invalidate();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (yes)
            {
                //создание полотна для рисования
                float a = (float)nudA.Value;
                float b = (float)nudB.Value;
                float c = (float)nudC.Value;
                Graphics polotno;
                polotno = e.Graphics;
                //начало координат в середине picturebox 
                polotno.TranslateTransform(picPorabola.Width / 2, picPorabola.Height / 2);                     
                float x = picPorabola.Width / 10;
                float y = picPorabola.Height / 10;
                Pen mypen = new Pen(Color.Black, 1);
                // система координат
                polotno.DrawLine(mypen, -10 * x, 0, 10 * x, 0);
                polotno.DrawLine(mypen, 0, -10 * y, 0, 10 * y);
                //штрихи на системе координат
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, -7, picPorabola.Width / 20 * i, 7, picPorabola.Width / 20 * i);
                }
                for (int i = -10; i <= 10; i++)
                {
                    polotno.DrawLine(mypen, picPorabola.Height / 20 * i, -7, picPorabola.Height / 20 * i, 7);
                }
                //построение пораболы
                for (float i = (float)-10; i < 10; i += (float)0.5)
                {
                    float y1 = -(float)(a * i * i + b * i + c);
                    float y2 = -(float)(a * (i + 0.5) * (i + 0.5) + b * (i + 0.5) + c);
                    float x1 = (float)(picPorabola.Width / 20 * i);
                    float x2 = (float)(picPorabola.Width / 20 * (i + 0.5));
                    y1 = (float)(picPorabola.Width / 20 * y1);
                    y2 = (float)(picPorabola.Width / 20 * y2);
                    polotno.DrawLine(pen, x1, y1, x2, y2);
                }                
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            //окно с выбором цвета
            if (yes)
            {      
                formcoloronform = new Formcolor();
                formcoloronform.picbackcolor.BackColor = picPorabola.BackColor;
                formcoloronform.picline.BackColor = pen.Color;//цвета из формы в форму с выбором цвета
                formcoloronform.ShowDialog();
                picPorabola.BackColor = formcoloronform.picbackcolor.BackColor;               
                pen.Color = formcoloronform.picline.BackColor;//цвета из выбора цвета в форму
                formcoloronform.Dispose();
                picPorabola.Invalidate();
            }
            else
            {
                MessageBox.Show("Сначала постройте график", "Внимание", MessageBoxButtons.OK);
            }
        }

        private void Formporabola_Load(object sender, EventArgs e)
        {
            
        }
    }
}
