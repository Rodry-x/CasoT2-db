namespace CasoT2_db.Formularios
{
    partial class FormArbolBB_Ejemplo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArbolBB_Ejemplo));
            panelArbolEjercicio1 = new Panel();
            label8 = new Label();
            button4 = new Button();
            txtBuscar = new TextBox();
            label7 = new Label();
            button3 = new Button();
            listViewMostrarInOrden = new ListView();
            txtNombre = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            txtCodigo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            panelArbolEjercicio1.SuspendLayout();
            SuspendLayout();
            // 
            // panelArbolEjercicio1
            // 
            panelArbolEjercicio1.Controls.Add(label8);
            panelArbolEjercicio1.Controls.Add(button4);
            panelArbolEjercicio1.Controls.Add(txtBuscar);
            panelArbolEjercicio1.Controls.Add(label7);
            panelArbolEjercicio1.Controls.Add(button3);
            panelArbolEjercicio1.Controls.Add(listViewMostrarInOrden);
            panelArbolEjercicio1.Controls.Add(txtNombre);
            panelArbolEjercicio1.Controls.Add(label6);
            panelArbolEjercicio1.Controls.Add(button2);
            panelArbolEjercicio1.Controls.Add(label5);
            panelArbolEjercicio1.Controls.Add(label4);
            panelArbolEjercicio1.Controls.Add(txtCodigo);
            panelArbolEjercicio1.Controls.Add(label3);
            panelArbolEjercicio1.Controls.Add(label2);
            panelArbolEjercicio1.Controls.Add(label1);
            panelArbolEjercicio1.Controls.Add(button1);
            panelArbolEjercicio1.Location = new Point(6, 5);
            panelArbolEjercicio1.Name = "panelArbolEjercicio1";
            panelArbolEjercicio1.Size = new Size(550, 630);
            panelArbolEjercicio1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(331, 258);
            label8.Name = "label8";
            label8.Size = new Size(172, 23);
            label8.TabIndex = 15;
            label8.Text = "Ordenar por InOrden";
            // 
            // button4
            // 
            button4.Location = new Point(188, 484);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += buscarPorCodigo_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(66, 448);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(216, 27);
            txtBuscar.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 425);
            label7.Name = "label7";
            label7.Size = new Size(135, 20);
            label7.TabIndex = 12;
            label7.Text = "Buscar por Código:";
            // 
            // button3
            // 
            button3.Location = new Point(404, 484);
            button3.Name = "button3";
            button3.Size = new Size(110, 35);
            button3.TabIndex = 11;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += actualizarListaMostrarInOrden_Click;
            // 
            // listViewMostrarInOrden
            // 
            listViewMostrarInOrden.Location = new Point(314, 284);
            listViewMostrarInOrden.Name = "listViewMostrarInOrden";
            listViewMostrarInOrden.Size = new Size(200, 188);
            listViewMostrarInOrden.TabIndex = 10;
            listViewMostrarInOrden.UseCompatibleStateImageBehavior = false;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(135, 330);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(147, 27);
            txtNombre.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(62, 332);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 8;
            label6.Text = "Nombre:";
            // 
            // button2
            // 
            button2.Location = new Point(188, 372);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += guardarLosDatos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 293);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 6;
            label5.Text = "Código:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 262);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 5;
            label4.Text = "Solución:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(135, 290);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(147, 27);
            txtCodigo.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(25, 97);
            label3.Name = "label3";
            label3.Size = new Size(505, 135);
            label3.TabIndex = 3;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 67);
            label2.Name = "label2";
            label2.Size = new Size(386, 23);
            label2.TabIndex = 2;
            label2.Text = "Ejemplo por busqueda InOrden (Carlitos y Jerry):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 16);
            label1.Name = "label1";
            label1.Size = new Size(363, 37);
            label1.TabIndex = 1;
            label1.Text = "Busqueda por Árbol Binario";
            // 
            // button1
            // 
            button1.Location = new Point(25, 565);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 0;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelArbolBB_Click;
            // 
            // FormArbolBB_Ejemplo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 643);
            Controls.Add(panelArbolEjercicio1);
            Name = "FormArbolBB_Ejemplo";
            Text = "FormArbolBB_Ejemplo";
            panelArbolEjercicio1.ResumeLayout(false);
            panelArbolEjercicio1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelArbolEjercicio1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private Label label6;
        private Button button2;
        private Label label5;
        private Label label4;
        private TextBox txtCodigo;
        private Button button3;
        private ListView listViewMostrarInOrden;
        private Button button4;
        private TextBox txtBuscar;
        private Label label7;
        private Label label8;
    }
}