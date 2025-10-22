using System;
using System.Windows.Forms;
using CasoT2_db.Utilidades;
using CasoT2_db.Estructura_De_Datos;

namespace CasoT2_db.Formularios
{
    public partial class FormArbolBB_Ejemplo : Form
    {
        public FormArbolBB_Ejemplo()
        {
            InitializeComponent();
        }
        public Panel PanelArbolEjercicio1 => panelArbolEjercicio1;

        private FormArbolBB formArbolBB;

        // Instancia del árbol para este formulario
        private readonly Ejercicio1ABB arbolEjercicio = new();

        private void guardarLosDatos_Click(object sender, EventArgs e)
        {
            // Validar código
            var codigoTexto = txtCodigo.Text?.Trim() ?? string.Empty;
            if (!int.TryParse(codigoTexto, out int codigo))
            {
                MessageBox.Show("Ingrese un código numérico válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Focus();
                return;
            }

            // Validar nombre
            var nombre = txtNombre.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese un nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            // Insertar en el árbol
            arbolEjercicio.Insertar(codigo, nombre);

            // Limpiar campos y devolver foco
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCodigo.Focus();

            // (Opcional) notificar al usuario
            MessageBox.Show("Datos guardados en el árbol.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cambiarAlPanelArbolBB_Click(object sender, EventArgs e)
        {
            formArbolBB = new FormArbolBB();
            PanelController.CambiarPanel(panelArbolEjercicio1, formArbolBB.PanelArbol);
        }

        private void actualizarListaMostrarInOrden_Click(object sender, EventArgs e)
        {
            listViewMostrarInOrden.Items.Clear();

            // Asegurar modo de vista para ver items simples
            listViewMostrarInOrden.View = View.List;

            var lista = arbolEjercicio.ObtenerInOrden();
            if (lista == null || lista.Count == 0)
            {
                MessageBox.Show("El árbol está vacío. Inserta datos primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var (codigo, nombre) in lista)
            {
                listViewMostrarInOrden.Items.Add(new ListViewItem($"Codigo: {codigo} - Nombre: {nombre}"));
            }
        }

        private void buscarPorCodigo_Click(object sender, EventArgs e)
        {
            listViewMostrarInOrden.Items.Clear();
            listViewMostrarInOrden.View = View.List;

            var texto = txtBuscar.Text?.Trim() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Ingresa un código para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            if (!int.TryParse(texto, out int codigoBuscar))
            {
                MessageBox.Show("El valor ingresado no es un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBuscar.Focus();
                return;
            }

            var nodo = arbolEjercicio.BuscarPorCodigo(codigoBuscar);
            if (nodo == null)
            {
                MessageBox.Show($"No se encontró ningún registro con código {codigoBuscar}.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar resultado en la lista
            listViewMostrarInOrden.Items.Add(new ListViewItem($"Codigo: {nodo.Codigo} - Nombre: {nodo.Nombre}"));
        }
    }
}
