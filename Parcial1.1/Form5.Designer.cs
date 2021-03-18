
namespace Parcial1._1
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flFichasDeJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.flPalabra = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIniciarJuego = new System.Windows.Forms.PictureBox();
            this.lblMostrarVidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // flFichasDeJuego
            // 
            this.flFichasDeJuego.Location = new System.Drawing.Point(12, 98);
            this.flFichasDeJuego.Name = "flFichasDeJuego";
            this.flFichasDeJuego.Size = new System.Drawing.Size(445, 300);
            this.flFichasDeJuego.TabIndex = 0;
            // 
            // flPalabra
            // 
            this.flPalabra.Location = new System.Drawing.Point(584, 257);
            this.flPalabra.Name = "flPalabra";
            this.flPalabra.Size = new System.Drawing.Size(608, 88);
            this.flPalabra.TabIndex = 2;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(779, 373);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(197, 39);
            this.lblMensaje.TabIndex = 3;
            this.lblMensaje.Text = "PERDISTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(342, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "ADIVINA LA PALABRA";
            // 
            // btnIniciarJuego
            // 
            this.btnIniciarJuego.Image = global::Parcial1._1.Properties.Resources.btn_comenzar;
            this.btnIniciarJuego.Location = new System.Drawing.Point(964, 24);
            this.btnIniciarJuego.Name = "btnIniciarJuego";
            this.btnIniciarJuego.Size = new System.Drawing.Size(283, 95);
            this.btnIniciarJuego.TabIndex = 5;
            this.btnIniciarJuego.TabStop = false;
            this.btnIniciarJuego.Click += new System.EventHandler(this.btnIniciarJuego_Click);
            // 
            // lblMostrarVidas
            // 
            this.lblMostrarVidas.AutoSize = true;
            this.lblMostrarVidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarVidas.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblMostrarVidas.Location = new System.Drawing.Point(577, 185);
            this.lblMostrarVidas.Name = "lblMostrarVidas";
            this.lblMostrarVidas.Size = new System.Drawing.Size(28, 37);
            this.lblMostrarVidas.TabIndex = 6;
            this.lblMostrarVidas.Text = "-";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 435);
            this.Controls.Add(this.lblMostrarVidas);
            this.Controls.Add(this.btnIniciarJuego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.flPalabra);
            this.Controls.Add(this.flFichasDeJuego);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnIniciarJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flFichasDeJuego;
        private System.Windows.Forms.FlowLayoutPanel flPalabra;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnIniciarJuego;
        private System.Windows.Forms.Label lblMostrarVidas;
    }
}