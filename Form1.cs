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
    public partial class Form1 : Form
    {
        Formporabola porabolaonform;
        Sinus sinusonform;
        giperbola giperbolaonform;
        linstep linsteponform;

        
        //для открытия других форм
        public Form1()
        {
            InitializeComponent();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            if (rdbPorabola.Checked)
            {
               porabolaonform = new Formporabola();
               porabolaonform.ShowDialog();             
               porabolaonform.Dispose();
                
            }
            else
            {
                if (rdbsin.Checked)
                {
                   sinusonform = new Sinus();
                   sinusonform.ShowDialog();             
                   sinusonform.Dispose();
                   
                }
                else
                {
                    if (rdbgiperbola.Checked)
                    {
                       giperbolaonform = new giperbola();
                       giperbolaonform.ShowDialog();
                       giperbolaonform.Dispose();
                       
                    }
                    else
                    {
                        if (rdblinstep.Checked)
                        {
                            linsteponform = new linstep();
                            linsteponform.ShowDialog();
                            linsteponform.Dispose();
                            
                        }
                        else
                        {
                            MessageBox.Show("Выберите функцию", "Ошибка", MessageBoxButtons.OK);
                        }
                    }
                    
                }
            }
            
            //открытие других форм, в зависимости от выбранной кнопки;если кнопка не выбрана, то вылезает окно с предупреждением
            
        }
    }
}
