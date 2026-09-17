using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace rpsai
{
    public partial class Form1 : Form
    {
        // Vector con los 3 valores base: 1 = piedra, 2 = papel, 3 = tijera
        public static List<int> vector = new List<int>() { 1, 2, 3 };
        public static int modo = 1; // 1 para entrenar y 2 para jugar 

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (pnlMenu != null)
            {
                pnlMenu.Left = (this.ClientSize.Width - pnlMenu.Width) / 2;
                pnlMenu.Top = (this.ClientSize.Height - pnlMenu.Height) / 2;
            }
        }

        // Boton de entrenar
        private void button1_Click(object sender, EventArgs e)
        {
            modo = 1;
            Form2 ventana = new Form2();
            ventana.ShowDialog();
        }

        // boton de jugar con entrenamiento
        private void button2_Click(object sender, EventArgs e)
        {
            modo = 2;
            Form2 ventana = new Form2();
            ventana.ShowDialog();
        }

        // Boton mostrar aprendizaje
        private void button3_Click(object sender, EventArgs e)
        {
            string textoVector = "";
            int piedra = 0;
            int papel = 0;
            int tijera = 0;

            // recorrer el vector para mostrarlo y contar las frecuencias
            for (int i = 0; i < vector.Count; i++)
            {
                textoVector += vector[i] + " ";

                if (vector[i] == 1) piedra++;
                if (vector[i] == 2) papel++;
                if (vector[i] == 3) tijera++;
            }

            MessageBox.Show("Vector (" + vector.Count + " elementos):\n" + textoVector +
                            "\n\nConteo:\n" +
                            "Piedra: " + piedra + "\n" +
                            "Papel: " + papel + "\n" +
                            "Tijera: " + tijera,
                            "Aprendizaje");
        }
    }
}