namespace CasoT2_db.Formularios
{
    partial class FormExplicacion1
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
            panelExplicacion1 = new Panel();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button4 = new Button();
            panelExplicacion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelExplicacion1
            // 
            panelExplicacion1.Controls.Add(button4);
            panelExplicacion1.Controls.Add(button3);
            panelExplicacion1.Controls.Add(pictureBox1);
            panelExplicacion1.Controls.Add(label2);
            panelExplicacion1.Controls.Add(button2);
            panelExplicacion1.Controls.Add(button1);
            panelExplicacion1.Controls.Add(label1);
            panelExplicacion1.Location = new Point(6, 5);
            panelExplicacion1.Name = "panelExplicacion1";
            panelExplicacion1.Size = new Size(550, 630);
            panelExplicacion1.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(283, 338);
            button3.Name = "button3";
            button3.Size = new Size(135, 44);
            button3.TabIndex = 8;
            button3.Text = "Ver el video";
            button3.UseVisualStyleBackColor = true;
            button3.Click += abriElVideoExplicacionPDF_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenLibro;
            pictureBox1.Location = new Point(100, 111);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 208);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(36, 85);
            label2.Name = "label2";
            label2.Size = new Size(150, 23);
            label2.TabIndex = 6;
            label2.Text = "Explicando El PDF";
            // 
            // button2
            // 
            button2.Location = new Point(434, 580);
            button2.Name = "button2";
            button2.Size = new Size(110, 46);
            button2.TabIndex = 5;
            button2.Text = "Siguiente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += cambiarAlPanelExplicacion;
            // 
            // button1
            // 
            button1.Location = new Point(6, 580);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 4;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelPrincipal;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(185, 16);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 3;
            label1.Text = "Explicación";
            // 
            // button4
            // 
            button4.Location = new Point(120, 338);
            button4.Name = "button4";
            button4.Size = new Size(127, 44);
            button4.TabIndex = 9;
            button4.Text = "Descargar PDF";
            button4.UseVisualStyleBackColor = true;
            button4.Click += abrirDescargaPDF_Click;
            // 
            // FormExplicacion1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 643);
            Controls.Add(panelExplicacion1);
            Name = "FormExplicacion1";
            Text = "FormExplicacion1";
            panelExplicacion1.ResumeLayout(false);
            panelExplicacion1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelExplicacion1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Label label2;
        private Button button4;
    }
}