namespace rpsai
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            pnlMenu = new Panel();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(139, 49);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(283, 46);
            label2.TabIndex = 1;
            label2.Text = "MENU PRINCIPAL";
            // 
            // button1
            // 
            button1.Location = new Point(162, 158);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(233, 92);
            button1.TabIndex = 2;
            button1.Text = "ENTRENAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(162, 316);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(233, 92);
            button2.TabIndex = 3;
            button2.Text = "JUGAR CON ENTRENAMIENTO";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(162, 466);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(233, 92);
            button3.TabIndex = 4;
            button3.Text = "MOSTRAR APRENDIZAJE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.Anchor = AnchorStyles.None;
            pnlMenu.AutoSize = true;
            pnlMenu.BackColor = Color.Transparent;
            pnlMenu.BackgroundImageLayout = ImageLayout.None;
            pnlMenu.Controls.Add(label2);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(button1);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Location = new Point(269, 17);
            pnlMenu.Margin = new Padding(4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(536, 630);
            pnlMenu.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1077, 734);
            Controls.Add(pnlMenu);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel pnlMenu;
    }
}
