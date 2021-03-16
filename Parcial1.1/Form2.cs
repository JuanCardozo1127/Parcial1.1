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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double lado;
        double basee;
        double area;
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lado = Convert.ToDouble(txtAltura.Text);
            basee = Convert.ToDouble(txtBase.Text);
            area = lado * basee;
            label3.Text = Convert.ToString("El area del cuadrado es: " + area);

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        public void volvear() {

            for(int x = )
        }
    }
}
