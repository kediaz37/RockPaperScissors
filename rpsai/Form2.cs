using System;
using System.Drawing;
using System.Windows.Forms;

namespace rpsai
{
    public partial class Form2 : Form
    {
        private readonly Random rnd = new Random();
        private int ronda = 1;
        private int victorias = 0;
        private int empates = 0;
        private int derrotas = 0;

        public Form2()
        {
            InitializeComponent();

            // Habilitar captura de teclado en el formulario
            this.KeyPreview = true;
            this.KeyDown += Form2_KeyDown;

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnPiedra, "Piedra (Presiona tecla 1)");
            toolTip.SetToolTip(btnPapel, "Papel (Presiona tecla 2)");
            toolTip.SetToolTip(btnTijera, "Tijera (Presiona tecla 3)");
            toolTip.SetToolTip(button2, "Volver al Menú Principal (ESC)");

            ActualizarCabecera();
            ActualizarMarcador();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CentrarContenedor();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CentrarContenedor();
        }

        private void CentrarContenedor()
        {
            if (pnlJuego != null)
            {
                pnlJuego.Left = Math.Max(0, (this.ClientSize.Width - pnlJuego.Width) / 2);
                pnlJuego.Top = Math.Max(0, (this.ClientSize.Height - pnlJuego.Height) / 2);
            }
        }

        private void Form2_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btnPiedra.PerformClick();
            }
            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btnPapel.PerformClick();
            }
            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btnTijera.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnPiedra_Click(object? sender, EventArgs e) => EjecutarJugada(1);

        private void btnPapel_Click(object? sender, EventArgs e) => EjecutarJugada(2);

        private void btnTijera_Click(object? sender, EventArgs e) => EjecutarJugada(3);

        private void EjecutarJugada(int usuario)
        {
            int maquina = 1;

            // eleccion de la maquina segun el modo
            if (Form1.modo == 1)
            {
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
                // elige una posición aleatoria del vector aprendido
                int indice = rnd.Next(0, Form1.vector.Count);
                maquina = Form1.vector[indice];
            }

            // mostrar el enfrentamiento visual en los picturebox
            pbJugador.Image = ObtenerImagenJugada(usuario);
            pbIA.Image = ObtenerImagenJugada(maquina);

            string txtUsuario = ObtenerNombreJugada(usuario);
            string txtMaquina = ObtenerNombreJugada(maquina);

            // Evaluar resultado 
            string resultado;
            if (usuario == maquina)
            {
                resultado = "¡EMPATE!";
                label2.ForeColor = Color.Gold;
                empates++;
            }
            else if ((usuario == 1 && maquina == 3) ||
                     (usuario == 2 && maquina == 1) ||
                     (usuario == 3 && maquina == 2))
            {
                resultado = "¡GANASTE ESTA RONDA!";
                label2.ForeColor = Color.LightGreen;
                victorias++;
            }
            else
            {
                resultado = "¡GANA LA MÁQUINA!";
                label2.ForeColor = Color.Crimson;
                derrotas++;
            }

            label2.Text = $"Tú: {txtUsuario}  vs  Máquina: {txtMaquina}\n{resultado}";

            ronda++;
            ActualizarCabecera();
            ActualizarMarcador();
        }

        private static string ObtenerNombreJugada(int jugada) => jugada switch
        {
            1 => "Piedra",
            2 => "Papel",
            3 => "Tijera",
            _ => ""
        };

        private static Image? ObtenerImagenJugada(int jugada) => jugada switch
        {
            1 => Properties.Resources.piedra,
            2 => Properties.Resources.papel,
            3 => Properties.Resources.tijera,
            _ => null
        };

        private void ActualizarCabecera()
        {
            string modoTexto = (Form1.modo == 1) ? "ENTRENAMIENTO" : "DUELO VS IA";
            label1.Text = $"{modoTexto} (Ronda {ronda})";
        }

        private void ActualizarMarcador()
        {
            lblMarcador.Text = $"Victorias: {victorias}   |   Empates: {empates}   |   Derrotas: {derrotas}";
        }

        // Boton regresar, la parte mas dificil del codigo.
        private void button2_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}
