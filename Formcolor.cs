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
    public partial class Formcolor : Form
    {
        public Formcolor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Formcolor_Load(object sender, EventArgs e)
        {
            
        }

        private void picbackcolor_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();            
            picbackcolor.BackColor = cd.Color;            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }
        private void picline_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            picline.BackColor = cd.Color;
        }
    }
}
