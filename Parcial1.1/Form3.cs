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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int n, i, fac = 1;

            n = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= n; i++)
            {
                fac = fac * i;
                label2.Text = "El factorial del numero " + n + " es : " + fac.ToString();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 frm = new Form4();

            frm.Show();
        }
    }
}
