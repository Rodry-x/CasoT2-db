namespace CasoT2_db.Formularios
{
    partial class FormPrincipal
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
            panelPrincipal = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelPrincipal
            // 
            panelPrincipal.Controls.Add(label2);
            panelPrincipal.Controls.Add(pictureBox1);
            panelPrincipal.Controls.Add(button5);
            panelPrincipal.Controls.Add(button1);
            panelPrincipal.Controls.Add(label4);
            panelPrincipal.Controls.Add(label3);
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(6, 5);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(550, 630);
            panelPrincipal.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 286);
            label2.Name = "label2";
            label2.Size = new Size(477, 28);
            label2.TabIndex = 10;
            label2.Text = "Ilustración de un Árbol Binario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.imagenAB;
            pictureBox1.Location = new Point(83, 329);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(383, 271);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button5
            // 
            button5.Location = new Point(228, 178);
            button5.Name = "button5";
            button5.Size = new Size(278, 48);
            button5.TabIndex = 8;
            button5.Text = "Ir a la seccion Explicación";
            button5.UseVisualStyleBackColor = true;
            button5.Click += cambiarAlPanelExplicacion;
            // 
            // button1
            // 
            button1.Location = new Point(228, 106);
            button1.Name = "button1";
            button1.Size = new Size(278, 48);
            button1.TabIndex = 4;
            button1.Text = "Arbol binario por busqueda";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelArbolBB;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 30F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(101, 17);
            label4.Name = "label4";
            label4.Size = new Size(360, 50);
            label4.TabIndex = 3;
            label4.Text = "Árbol Binario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(87, 113);
            label3.Name = "label3";
            label3.Size = new Size(117, 28);
            label3.TabIndex = 2;
            label3.Text = "Ejemplo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 185);
            label1.Name = "label1";
            label1.Size = new Size(177, 28);
            label1.TabIndex = 0;
            label1.Text = "Explicación";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 643);
            Controls.Add(panelPrincipal);
            Name = "FormPrincipal";
            Text = "Caso Árbol Binario T2";
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelPrincipal;
        private Label label3;
        private Label label1;
        private Button button1;
        private Label label4;
        private Button button5;
        private PictureBox pictureBox1;
        private Label label2;
    }
}