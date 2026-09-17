namespace rpsai
{
    partial class Form2
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
            button2 = new Button();
            pnlJuego = new Panel();
            label1 = new Label();
            lblMarcador = new Label();
            label2 = new Label();
            lblJugador = new Label();
            pbJugador = new PictureBox();
            lblVS = new Label();
            lblIA = new Label();
            pbIA = new PictureBox();
            lblInstruccion = new Label();
            btnPiedra = new Button();
            btnPapel = new Button();
            btnTijera = new Button();
            lblAtajos = new Label();
            pnlJuego.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbJugador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbIA).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(35, 45, 65);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(80, 110, 150);
            button2.FlatAppearance.BorderSize = 1;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 70, 100);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(25, 20);
            button2.Name = "button2";
            button2.Size = new Size(110, 38);
            button2.TabIndex = 0;
            button2.Text = "← Volver";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pnlJuego
            // 
            pnlJuego.Anchor = AnchorStyles.None;
            pnlJuego.BackColor = Color.Transparent;
            pnlJuego.Controls.Add(lblAtajos);
            pnlJuego.Controls.Add(btnTijera);
            pnlJuego.Controls.Add(btnPapel);
            pnlJuego.Controls.Add(btnPiedra);
            pnlJuego.Controls.Add(lblInstruccion);
            pnlJuego.Controls.Add(pbIA);
            pnlJuego.Controls.Add(lblIA);
            pnlJuego.Controls.Add(lblVS);
            pnlJuego.Controls.Add(pbJugador);
            pnlJuego.Controls.Add(lblJugador);
            pnlJuego.Controls.Add(label2);
            pnlJuego.Controls.Add(lblMarcador);
            pnlJuego.Controls.Add(label1);
            pnlJuego.Location = new Point(114, 35);
            pnlJuego.Name = "pnlJuego";
            pnlJuego.Size = new Size(920, 620);
            pnlJuego.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(920, 36);
            label1.TabIndex = 0;
            label1.Text = "DUELO VS IA (Ronda 1)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMarcador
            // 
            lblMarcador.BackColor = Color.Transparent;
            lblMarcador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMarcador.ForeColor = Color.LightSteelBlue;
            lblMarcador.Location = new Point(0, 48);
            lblMarcador.Name = "lblMarcador";
            lblMarcador.Size = new Size(920, 26);
            lblMarcador.TabIndex = 1;
            lblMarcador.Text = "Victorias: 0  |  Empates: 0  |  Derrotas: 0";
            lblMarcador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(0, 80);
            label2.Name = "label2";
            label2.Size = new Size(920, 52);
            label2.TabIndex = 2;
            label2.Text = "¡Elige tu jugada para comenzar el duelo!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJugador
            // 
            lblJugador.BackColor = Color.Transparent;
            lblJugador.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblJugador.ForeColor = Color.DeepSkyBlue;
            lblJugador.Location = new Point(145, 150);
            lblJugador.Name = "lblJugador";
            lblJugador.Size = new Size(170, 28);
            lblJugador.TabIndex = 3;
            lblJugador.Text = "TÚ";
            lblJugador.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbJugador
            // 
            pbJugador.BackColor = Color.Transparent;
            pbJugador.Location = new Point(145, 180);
            pbJugador.Name = "pbJugador";
            pbJugador.Size = new Size(170, 170);
            pbJugador.SizeMode = PictureBoxSizeMode.Zoom;
            pbJugador.TabIndex = 4;
            pbJugador.TabStop = false;
            // 
            // lblVS
            // 
            lblVS.BackColor = Color.Transparent;
            lblVS.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblVS.ForeColor = Color.Gold;
            lblVS.Location = new Point(410, 230);
            lblVS.Name = "lblVS";
            lblVS.Size = new Size(100, 50);
            lblVS.TabIndex = 5;
            lblVS.Text = "VS";
            lblVS.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblIA
            // 
            lblIA.BackColor = Color.Transparent;
            lblIA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblIA.ForeColor = Color.OrangeRed;
            lblIA.Location = new Point(605, 150);
            lblIA.Name = "lblIA";
            lblIA.Size = new Size(170, 28);
            lblIA.TabIndex = 6;
            lblIA.Text = "MÁQUINA / IA";
            lblIA.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pbIA
            // 
            pbIA.BackColor = Color.Transparent;
            pbIA.Location = new Point(605, 180);
            pbIA.Name = "pbIA";
            pbIA.Size = new Size(170, 170);
            pbIA.SizeMode = PictureBoxSizeMode.Zoom;
            pbIA.TabIndex = 7;
            pbIA.TabStop = false;
            // 
            // lblInstruccion
            // 
            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblInstruccion.ForeColor = Color.White;
            lblInstruccion.Location = new Point(0, 390);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(920, 28);
            lblInstruccion.TabIndex = 8;
            lblInstruccion.Text = "Elige tu jugada:";
            lblInstruccion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPiedra
            // 
            btnPiedra.BackColor = Color.FromArgb(25, 35, 55);
            btnPiedra.BackgroundImage = Properties.Resources.piedra;
            btnPiedra.BackgroundImageLayout = ImageLayout.Zoom;
            btnPiedra.Cursor = Cursors.Hand;
            btnPiedra.FlatAppearance.BorderColor = Color.FromArgb(0, 180, 255);
            btnPiedra.FlatAppearance.BorderSize = 2;
            btnPiedra.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 70, 110);
            btnPiedra.FlatStyle = FlatStyle.Flat;
            btnPiedra.Location = new Point(255, 425);
            btnPiedra.Name = "btnPiedra";
            btnPiedra.Size = new Size(110, 110);
            btnPiedra.TabIndex = 9;
            btnPiedra.UseVisualStyleBackColor = false;
            btnPiedra.Click += btnPiedra_Click;
            // 
            // btnPapel
            // 
            btnPapel.BackColor = Color.FromArgb(25, 35, 55);
            btnPapel.BackgroundImage = Properties.Resources.papel;
            btnPapel.BackgroundImageLayout = ImageLayout.Zoom;
            btnPapel.Cursor = Cursors.Hand;
            btnPapel.FlatAppearance.BorderColor = Color.FromArgb(0, 220, 180);
            btnPapel.FlatAppearance.BorderSize = 2;
            btnPapel.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 85, 95);
            btnPapel.FlatStyle = FlatStyle.Flat;
            btnPapel.Location = new Point(405, 425);
            btnPapel.Name = "btnPapel";
            btnPapel.Size = new Size(110, 110);
            btnPapel.TabIndex = 10;
            btnPapel.UseVisualStyleBackColor = false;
            btnPapel.Click += btnPapel_Click;
            // 
            // btnTijera
            // 
            btnTijera.BackColor = Color.FromArgb(25, 35, 55);
            btnTijera.BackgroundImage = Properties.Resources.tijera;
            btnTijera.BackgroundImageLayout = ImageLayout.Zoom;
            btnTijera.Cursor = Cursors.Hand;
            btnTijera.FlatAppearance.BorderColor = Color.FromArgb(255, 140, 0);
            btnTijera.FlatAppearance.BorderSize = 2;
            btnTijera.FlatAppearance.MouseOverBackColor = Color.FromArgb(95, 65, 45);
            btnTijera.FlatStyle = FlatStyle.Flat;
            btnTijera.Location = new Point(555, 425);
            btnTijera.Name = "btnTijera";
            btnTijera.Size = new Size(110, 110);
            btnTijera.TabIndex = 11;
            btnTijera.UseVisualStyleBackColor = false;
            btnTijera.Click += btnTijera_Click;
            // 
            // lblAtajos
            // 
            lblAtajos.BackColor = Color.Transparent;
            lblAtajos.Font = new Font("Segoe UI", 10F);
            lblAtajos.ForeColor = Color.LightGray;
            lblAtajos.Location = new Point(0, 560);
            lblAtajos.Name = "lblAtajos";
            lblAtajos.Size = new Size(920, 25);
            lblAtajos.TabIndex = 12;
            lblAtajos.Text = "[ 1 ] Piedra       [ 2 ] Papel       [ 3 ] Tijera       [ ESC ] Volver";
            lblAtajos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1149, 690);
            Controls.Add(button2);
            Controls.Add(pnlJuego);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Piedra, Papel o Tijera vs IA";
            WindowState = FormWindowState.Maximized;
            pnlJuego.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbJugador).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button2;
        private Panel pnlJuego;
        private Label label1;
        private Label lblMarcador;
        private Label label2;
        private Label lblJugador;
        private PictureBox pbJugador;
        private Label lblVS;
        private Label lblIA;
        private PictureBox pbIA;
        private Label lblInstruccion;
        private Button btnPiedra;
        private Button btnPapel;
        private Button btnTijera;
        private Label lblAtajos;
    }
}
