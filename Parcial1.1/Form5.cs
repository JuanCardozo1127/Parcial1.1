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
    public partial class Form5 : Form
    {
        char[] PalabrasAdivinadas;
        int Oportunidades;
        char[] PalabraSeleccionada;
        string[] Palabras;
        char[] Alfabeto;



        public Form5()
        {
            InitializeComponent();
        }
        public void IniciarJuego()
        {
            //valores iniciales del juego
            flFichasDeJuego.Controls.Clear(); 
            flFichasDeJuego.Enabled = true;
            lblMensaje.Visible = false;
            Oportunidades = 7;//fallo
            btnIniciarJuego.Image = Properties.Resources.btn_comenzar;
            Palabras = new string[] { "rojo","azul","negro","blanco","amarillo","verde","rosado","morado","cafe","gris" };
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            //palabra aletoria-adivinar
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);
            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;

            //ciclo que calga el alfabeto en el flow layout
            foreach (char LetraAlfabeto in Alfabeto)
            {
                Button btnLetra = new Button();
                btnLetra.Tag = "";
                btnLetra.Text = LetraAlfabeto.ToString();
                btnLetra.Width = 60;
                btnLetra.Height = 40;
                btnLetra.Click += Compara;//cuando el ususario selecciones cualquier letra entrara en la funcion
                btnLetra.ForeColor = Color.White;
                btnLetra.Font = new Font(btnLetra.Font.Name, 15, FontStyle.Bold);
                btnLetra.BackgroundImageLayout = ImageLayout.Center;
                btnLetra.BackColor = Color.Black;
                btnLetra.Name = LetraAlfabeto.ToString();
                flFichasDeJuego.Controls.Add(btnLetra);
            }
            flPalabra.Controls.Clear();

            //ciclo que carga el alfabeto en un folwlayout
            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                Button Letra = new Button();
                Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                Letra.Width = 46;
                Letra.Height = 80;
                Letra.ForeColor = Color.Purple;
                Letra.Text = "-";
                Letra.Font = new Font(Letra.Font.Name, 32, FontStyle.Bold);
                Letra.BackgroundImageLayout = ImageLayout.Center;
                Letra.BackColor = Color.White;
                Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                Letra.Name = "Adivinado" + IndiceValorLetra.ToString();
                flPalabra.Controls.Add(Letra);
            }

        }

        void Compara(object sender, EventArgs e)
        {
            bool encontrado = false;
            //botonpresionado se desactiva

            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;

            //compara la letra seleccionada con las letras de la palabra
            for (int indiceRevisar = 0; indiceRevisar < PalabrasAdivinadas.Length; indiceRevisar++)
            {
                if (PalabrasAdivinadas[indiceRevisar] == Char.Parse(btn.Text))
                {
                    //si existe la letra actualiza la palabra agregando el valor correspondiente
                    Button tbx = this.Controls.Find("Adivinado" + indiceRevisar, true).FirstOrDefault() as Button;
                    tbx.Text = PalabrasAdivinadas[indiceRevisar].ToString();
                    PalabrasAdivinadas[indiceRevisar] = '-';
                    encontrado = true;
                }
            }

            //verifica si todas la letras de las palabra estan destapadas
            bool Ganaste = true;

            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < PalabrasAdivinadas.Length; indiceAnalizadorGanador++)
            {
                //si el usuario tiene letras pendientes por destapar se cambiara el estatus
                if (PalabrasAdivinadas[indiceAnalizadorGanador] != '-')
                {
                    Ganaste = false;
                }

            }
            //si el estatus de la variable no cambia quiere decir que el usuario gano
            if (Ganaste)
            {
                MessageBox.Show("GANASTE");
            }

            if (!encontrado)
            {
                Oportunidades = Oportunidades - 1;
                lblMostrarVidas.Text = "TE QUEDAN " + Oportunidades.ToString() + " VIDAS : ";

                //si ya se acabaron los intentos
                if (Oportunidades == 0)
                {
                    lblMensaje.Visible = true;
                    // muestra la palabra que el ususario intentaba descubrir
                    for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
                    {
                        Button btnLetra = this.Controls.Find("Adivinado" + IndiceValorLetra, true).FirstOrDefault() as Button;
                        btnLetra.Text = btnLetra.Tag.ToString();
                    }

                    //desactiva las fichas y cambia el boton de re
                    flFichasDeJuego.Enabled = false;
                }
            }
        }



        private void Form5_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            IniciarJuego();
        }
    }
}
