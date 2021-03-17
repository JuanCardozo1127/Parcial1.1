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
            label5.Text = Convert.ToString("-");
        }
        public void SumaDificil()
        {
            String ejemplo = "12 2568 368 120";
            char[] delimitador = { ' ' };
            string[] trozos = ejemplo.Split(delimitador);
            int i;
            for (i = 0; i < trozos.Length; i++)
            {
                Console.WriteLine("Fragmento {0} = {1}", (i + 1), trozos[i]);
            }
            int temporal = Int16.Parse(trozos[0]);
            int temporal1 = Int16.Parse(trozos[1]);
            int temporal2 = Int16.Parse(trozos[2]);
            int temporal3 = Int16.Parse(trozos[3]);

            int suma = temporal + temporal1 + temporal2 + temporal3;
            label5.Text = Convert.ToString("La suma es: " + suma);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form3 frm = new Form3();

            frm.Show();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            SumaDificil();
        }
    }
}
