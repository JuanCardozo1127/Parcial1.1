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
        string f1;
        string f2;
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

            f1 = txtPalabra.Text;
            
            for (int x = f1.Length - 1; x>=0; x--)
            {
                f2 += f1[x];
            }
            label6.Text = Convert.ToString("La palabras al reves es: " + f2);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            volvear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPalabra.Text = "";
            txtBase.Text = "";
            txtAltura.Text = "";
            f2 = "";
            label6.Text = Convert.ToString("-");
            label3.Text = Convert.ToString("-");
        }
    }
}
