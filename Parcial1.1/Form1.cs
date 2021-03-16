using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new Form2();
            formulario.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNumMayor_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txtN1.Text);
            int num2 = Convert.ToInt32(txtN2.Text);
            if (num1>=num2)
            {
                lblResultado.Text = "EL NUMERO MAYOR ES:  " + num1;
            }
            if (num2 >= num1)
            {
                lblResultado.Text = "EL NUMERO MAYOR ES:  " + num2;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtN1.Text = "";
            txtN2.Text = "";
        }
    }
}
