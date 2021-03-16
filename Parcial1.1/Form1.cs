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
            lblResultado.Text = Convert.ToString("-");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        string cadena;
        int a, E, i, o, u;//contadores de las vocales
        private void btnComprobar_Click(object sender, EventArgs e)
        {
            cadena = txtCadena.Text;//almacenar cadena del cuadro de texto
            for(int x=0;x<cadena.Length; x++)
            {
                if (cadena[x] == 'a' || cadena[x] == 'A')
                    a++;
                if (cadena[x] == 'e' || cadena[x] == 'E')
                    E++;
                if (cadena[x] == 'i' || cadena[x] == 'I')
                    i++;
                if (cadena[x] == 'o' || cadena[x] == 'O')
                    o++;
                if (cadena[x] == 'u' || cadena[x] == 'U')
                    u++;
            }
            txtA.Text = a.ToString();
            txtE.Text = E.ToString();
            txtI.Text = i.ToString();
            txtO.Text = o.ToString();
            txtU.Text = u.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            a = 0; E = 0; i = 0; o = 0; u = 0;
            txtCadena.Clear();
            txtA.Clear();
            txtE.Clear();
            txtI.Clear();
            txtO.Clear();
            txtU.Clear();

        }
    }
    }

