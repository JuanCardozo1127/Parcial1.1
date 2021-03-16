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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        string palabra, inverso, car;
        int tamaño;

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtInversa.Text = "";
            txtPolindromo.Text = "";
            txtPalabra.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            palabra = txtPalabra.Text.Trim(); 
            tamaño = palabra.Length;
            inverso = "";
            for (int x = tamaño - 1; x >= 0; x--)
            {
                car = palabra.Substring(x, 1);
                inverso = inverso + car;
            }

            txtInversa.Text = inverso;

            if (palabra == inverso)
            {
                txtPolindromo.Text = "Es palindromo";
            }
            else
            {
                txtPolindromo.Text = "No Es palindromo";
            }
        }

    }
}
