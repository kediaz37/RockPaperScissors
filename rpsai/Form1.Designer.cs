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
            label1.Location = new Point(292, 39);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(106, 28);
            label2.Name = "label2";
            label2.Size = new Size(226, 37);
            label2.TabIndex = 1;
            label2.Text = "MENU PRINCIPAL";
            // 
            // button1
            // 
            button1.Location = new Point(126, 113);
            button1.Name = "button1";
            button1.Size = new Size(181, 66);
            button1.TabIndex = 2;
            button1.Text = "ENTRENAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(126, 226);
            button2.Name = "button2";
            button2.Size = new Size(181, 66);
            button2.TabIndex = 3;
            button2.Text = "JUGAR CON ENTRENAMIENTO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(126, 333);
            button3.Name = "button3";
            button3.Size = new Size(181, 66);
            button3.TabIndex = 4;
            button3.Text = "MOSTRAR APRENDIZAJE";
            button3.UseVisualStyleBackColor = true;
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
            pnlMenu.Location = new Point(209, 12);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(417, 450);
            pnlMenu.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 524);
            Controls.Add(pnlMenu);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
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
