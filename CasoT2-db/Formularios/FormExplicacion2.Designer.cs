namespace CasoT2_db.Formularios
{
    partial class FormExplicacion2
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
            panelExplicacion2 = new Panel();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            panelExplicacion2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelExplicacion2
            // 
            panelExplicacion2.Controls.Add(button3);
            panelExplicacion2.Controls.Add(pictureBox1);
            panelExplicacion2.Controls.Add(label3);
            panelExplicacion2.Controls.Add(button2);
            panelExplicacion2.Controls.Add(button1);
            panelExplicacion2.Controls.Add(label1);
            panelExplicacion2.Location = new Point(6, 5);
            panelExplicacion2.Name = "panelExplicacion2";
            panelExplicacion2.Size = new Size(550, 630);
            panelExplicacion2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenBodega1;
            pictureBox1.Location = new Point(109, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 236);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 88);
            label3.Name = "label3";
            label3.Size = new Size(194, 23);
            label3.TabIndex = 4;
            label3.Text = "Explicando el ejercicio 1";
            // 
            // button2
            // 
            button2.Location = new Point(218, 359);
            button2.Name = "button2";
            button2.Size = new Size(135, 44);
            button2.TabIndex = 5;
            button2.Text = "Ver el Video";
            button2.UseVisualStyleBackColor = true;
            button2.Click += abrirElVideo_ExplicandoCodigoEjemplo1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(6, 580);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 3;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelExplicacion;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(185, 16);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 2;
            label1.Text = "Explicación";
            // 
            // button3
            // 
            button3.Location = new Point(400, 580);
            button3.Name = "button3";
            button3.Size = new Size(144, 46);
            button3.TabIndex = 7;
            button3.Text = "Form Descartado";
            button3.UseVisualStyleBackColor = true;
            button3.Click += cambiandoAlPanelArbolPregunta_Click;
            // 
            // FormExplicacion2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 643);
            Controls.Add(panelExplicacion2);
            Name = "FormExplicacion2";
            Text = "FormExplicacion2";
            panelExplicacion2.ResumeLayout(false);
            panelExplicacion2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelExplicacion2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button3;
    }
}