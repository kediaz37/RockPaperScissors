using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace rpsai
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int ronda = 1;

        public Form2()
        {
            InitializeComponent();

            radioButton1.Checked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // eleccion del jugador
            int usuario = 1; // piedra
            if (radioButton2.Checked) usuario = 2; // papel
            if (radioButton3.Checked) usuario = 3; // tijera

            int maquina = 1;

            // eleccion de la máquina segun el modo
            if (Form1.modo == 1)
            {
                // En entrenamiento saca un numero aleatorio simple del 1 al 3
                maquina = rnd.Next(1, 4);

                // guarda la opcion que le ganaria al usuario
                if (Form1.vector.Count < 200) // limite de 200 aprendizajes
                {
                    if (usuario == 1) Form1.vector.Add(2); 
                    else if (usuario == 2) Form1.vector.Add(3); 
                    else if (usuario == 3) Form1.vector.Add(1); 
                }
            }
            else
            {
                // elige una posicion random del vector
                int indice = rnd.Next(0, Form1.vector.Count);
                maquina = Form1.vector[indice];
            }

            // convertir numero a nombre
            string txtUsuario = "";
            if (usuario == 1) txtUsuario = "Piedra";
            if (usuario == 2) txtUsuario = "Papel";
            if (usuario == 3) txtUsuario = "Tijera";

            string txtMaquina = "";
            if (maquina == 1) txtMaquina = "Piedra";
            if (maquina == 2) txtMaquina = "Papel";
            if (maquina == 3) txtMaquina = "Tijera";

            // mostrar resultado
            string resultado = "";
            if (usuario == maquina)
            {
                resultado = "EMPATE.";
            }
            else if ((usuario == 1 && maquina == 3) ||
                     (usuario == 2 && maquina == 1) ||
                     (usuario == 3 && maquina == 2))
            {
                resultado = "GANA EL USUARIO.";
            }
            else
            {
                resultado = "GANA LA MÁQUINA.";
            }

           
            string mensaje = "Movimiento del usuario: " + txtUsuario + "\n" +
                             "Movimiento de la Máquina: " + txtMaquina + "\n" +
                             resultado;

            MessageBox.Show(mensaje, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            ronda++;
        }

        // Boton regresar, la parte mas dificil del codigo.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}