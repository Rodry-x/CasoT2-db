namespace CasoT2_db.Formularios
{
    partial class FormArbolBB
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
            panelArbolBB = new Panel();
            button6 = new Button();
            listViewOrden = new ListView();
            columnTipoOrden = new ColumnHeader();
            columnNumeros = new ColumnHeader();
            button5 = new Button();
            button3 = new Button();
            label4 = new Label();
            button2 = new Button();
            txtNumero = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            label1 = new Label();
            panelArbolBB.SuspendLayout();
            SuspendLayout();
            // 
            // panelArbolBB
            // 
            panelArbolBB.Controls.Add(button6);
            panelArbolBB.Controls.Add(listViewOrden);
            panelArbolBB.Controls.Add(button5);
            panelArbolBB.Controls.Add(button3);
            panelArbolBB.Controls.Add(label4);
            panelArbolBB.Controls.Add(button2);
            panelArbolBB.Controls.Add(txtNumero);
            panelArbolBB.Controls.Add(label3);
            panelArbolBB.Controls.Add(label2);
            panelArbolBB.Controls.Add(button1);
            panelArbolBB.Controls.Add(label1);
            panelArbolBB.Location = new Point(6, 5);
            panelArbolBB.Name = "panelArbolBB";
            panelArbolBB.Size = new Size(550, 630);
            panelArbolBB.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(182, 505);
            button6.Name = "button6";
            button6.Size = new Size(150, 29);
            button6.TabIndex = 12;
            button6.Text = "Destruir Árbol";
            button6.UseVisualStyleBackColor = true;
            button6.Click += destruirArbol_Click;
            // 
            // listViewOrden
            // 
            listViewOrden.Columns.AddRange(new ColumnHeader[] { columnTipoOrden, columnNumeros });
            listViewOrden.Location = new Point(53, 250);
            listViewOrden.Name = "listViewOrden";
            listViewOrden.Size = new Size(460, 249);
            listViewOrden.TabIndex = 11;
            listViewOrden.UseCompatibleStateImageBehavior = false;
            listViewOrden.View = View.Details;
            // 
            // columnTipoOrden
            // 
            columnTipoOrden.Text = "Tipo de orden";
            columnTipoOrden.Width = 155;
            // 
            // columnNumeros
            // 
            columnNumeros.Text = "Lista";
            columnNumeros.Width = 300;
            // 
            // button5
            // 
            button5.Location = new Point(395, 565);
            button5.Name = "button5";
            button5.Size = new Size(135, 50);
            button5.TabIndex = 10;
            button5.Text = "Otro Ejemplo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += cambiarAlEjemplo2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(351, 505);
            button3.Name = "button3";
            button3.Size = new Size(163, 29);
            button3.TabIndex = 8;
            button3.Text = "Actualizar lista";
            button3.UseVisualStyleBackColor = true;
            button3.Click += mostrarLista_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(23, 211);
            label4.Name = "label4";
            label4.Size = new Size(220, 23);
            label4.TabIndex = 6;
            label4.Text = "Mostrando el Árbol Binario:";
            // 
            // button2
            // 
            button2.Location = new Point(378, 160);
            button2.Name = "button2";
            button2.Size = new Size(135, 29);
            button2.TabIndex = 5;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += guardarNumero_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(182, 127);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(331, 27);
            txtNumero.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 130);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 3;
            label3.Text = "Ingresar número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(23, 92);
            label2.Name = "label2";
            label2.Size = new Size(291, 23);
            label2.TabIndex = 2;
            label2.Text = "Añadiendo números al Árbol Binario";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10F);
            button1.Location = new Point(25, 565);
            button1.Name = "button1";
            button1.Size = new Size(120, 50);
            button1.TabIndex = 1;
            button1.Text = "Atras";
            button1.UseVisualStyleBackColor = true;
            button1.Click += cambiarAlPanelPrincipal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 16);
            label1.Name = "label1";
            label1.Size = new Size(363, 37);
            label1.TabIndex = 0;
            label1.Text = "Busqueda por Árbol Binario";
            // 
            // FormArbolBB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 643);
            Controls.Add(panelArbolBB);
            Name = "FormArbolBB";
            Text = "FormArbolBB";
            panelArbolBB.ResumeLayout(false);
            panelArbolBB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelArbolBB;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txtNumero;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label label4;
        private Button button5;
        private ListView listViewOrden;
        private ColumnHeader columnTipoOrden;
        private ColumnHeader columnNumeros;
        private Button button6;
    }
}