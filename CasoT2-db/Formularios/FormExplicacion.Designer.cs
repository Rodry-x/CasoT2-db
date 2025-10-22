namespace CasoT2_db.Formularios
{
    partial class FormExplicacion
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
            panelExplicacion = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelExplicacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelExplicacion
            // 
            panelExplicacion.Controls.Add(button5);
            panelExplicacion.Controls.Add(button4);
            panelExplicacion.Controls.Add(button3);
            panelExplicacion.Controls.Add(pictureBox2);
            panelExplicacion.Controls.Add(button2);
            panelExplicacion.Controls.Add(pictureBox1);
            panelExplicacion.Controls.Add(label3);
            panelExplicacion.Controls.Add(label2);
            panelExplicacion.Controls.Add(label1);
            panelExplicacion.Controls.Add(button1);
            panelExplicacion.Location = new Point(6, 5);
            panelExplicacion.Name = "panelExplicacion";
            panelExplicacion.Size = new Size(550, 630);
            panelExplicacion.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(110, 272);
            button5.Name = "button5";
            button5.Size = new Size(139, 41);
            button5.TabIndex = 9;
            button5.Text = "Ver el diagrama";
            button5.UseVisualStyleBackColor = true;
            button5.Click += abrirLinkDelDiagrama_Click;
            // 
            // button4
            // 
            button4.Location = new Point(409, 576);
            button4.Name = "button4";
            button4.Size = new Size(135, 50);
            button4.TabIndex = 8;
            button4.Text = "Siguiente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += cambiarAlPanelExplicacion2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(160, 540);
            button3.Name = "button3";
            button3.Size = new Size(206, 41);
            button3.TabIndex = 7;
            button3.Text = "Ir al video";
            button3.UseVisualStyleBackColor = true;
            button3.Click += abrirElVideo_Ejemplo1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.imagenCodigo;
            pictureBox2.Location = new Point(125, 362);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 170);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.Location = new Point(289, 272);
            button2.Name = "button2";
            button2.Size = new Size(139, 41);
            button2.TabIndex = 5;
            button2.Text = "Ir al video";
            button2.UseVisualStyleBackColor = true;
            button2.Click += abrirElVideo_PreInPostOrden_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenABNumeros;
            pictureBox1.Location = new Point(89, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 333);
            label3.Name = "label3";
            label3.Size = new Size(170, 23);
            label3.TabIndex = 3;
            label3.Text = "Explicando el código";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 67);
            label2.Name = "label2";
            label2.Size = new Size(326, 23);
            label2.TabIndex = 2;
            label2.Text = "¿Que son PreOrden, InOrden, PostOrden?";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(185, 16);
            label1.Name = "label1";
            label1.Size = new Size(169, 41);
            label1.TabIndex = 1;
            label1.Text = "Explicación";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(6, 580);
            button1.Name = "button1";
            button1.Size = new Size(120, 46);
            button1.TabIndex = 0;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelPrincipal;
            // 
            // FormExplicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 643);
            Controls.Add(panelExplicacion);
            Name = "FormExplicacion";
            Text = "FormExplicacion";
            panelExplicacion.ResumeLayout(false);
            panelExplicacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelExplicacion;
        private Button button1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Button button2;
        private PictureBox pictureBox1;
        private Button button3;
        private PictureBox pictureBox2;
        private Button button4;
        private Button button5;
    }
}