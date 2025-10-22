using CasoT2_db.Estructura_De_Datos;
using CasoT2_db.Utilidades;

namespace CasoT2_db.Formularios
{
    public partial class FormArbolBB : Form
    {
        public FormArbolBB()
        {
            InitializeComponent();
        }

        private FormPrincipal formPrincipal;
        private FormArbolBB_Ejemplo formArbolBB_Ejemplo;

        // Instancia del árbol donde se guardan los números
        private readonly ArbolBinarioNum arbol = new ArbolBinarioNum();

        public Panel PanelArbol => panelArbolBB;

        // Guarda el número escrito en txtNumero en el árbol (valida que sea entero)
        private void guardarNumero_Click(object sender, EventArgs e)
        {
            string texto = txtNumero.Text?.Trim() ?? string.Empty;

            if (string.IsNullOrWhiteSpace(texto))
            {
                MessageBox.Show("Escribe un número antes de guardar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(texto, out int numero))
            {
                MessageBox.Show("El valor ingresado no es un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insertar en el árbol (la implementación actual ignora duplicados)
            arbol.Insertar(numero);

            // Limpiar la caja de texto y devolver foco
            txtNumero.Clear();
            txtNumero.Focus();

            // Confirmación
            MessageBox.Show($"Número {numero} guardado en el árbol.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Muestra las tres formas de recorrido en la listViewOrden
        private void mostrarLista_Click(object sender, EventArgs e)
        {
            listViewOrden.Items.Clear();

            if (arbol.IsEmpty())
            {
                MessageBox.Show("El árbol está vacío. Inserta números primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var inorden = arbol.InOrden();
            var preorden = arbol.PreOrden();
            var postorden = arbol.PostOrden();

            listViewOrden.Items.Add(new ListViewItem(new[]
            {
                "Raiz del Árbol:",
                (arbol.GetRaiz()?.Valor.ToString() ?? "(vacío)")
            }));

            // Añadir filas con el tipo de orden y la lista formateada
            listViewOrden.Items.Add(new ListViewItem(new[]
            {
                "PreOrden",
                (preorden.Any() ? string.Join(", ", preorden) : "(vacío)")
            }));

            listViewOrden.Items.Add(new ListViewItem(new[]
            {
                "InOrden",
                (inorden.Any() ? string.Join(", ", inorden) : "(vacío)")
            }));

            listViewOrden.Items.Add(new ListViewItem(new[]
            {
                "PostOrden",
                (postorden.Any() ? string.Join(", ", postorden) : "(vacío)")
            }));
        }

        private void cambiarAlPanelPrincipal_Click(object sender, EventArgs e)
        {
            formPrincipal = new FormPrincipal();
            PanelController.CambiarPanel(panelArbolBB, formPrincipal.PanelPrincipal);
        }

        private void cambiarAlEjemplo2_Click(object sender, EventArgs e)
        {
            formArbolBB_Ejemplo = new FormArbolBB_Ejemplo();
            PanelController.CambiarPanel(panelArbolBB, formArbolBB_Ejemplo.PanelArbolEjercicio1);
        }

        private void destruirArbol_Click(object sender, EventArgs e)
        {
            // Vaciar la estructura de datos
            arbol.Clear();

            // Limpiar la vista que muestra los recorridos
            listViewOrden.Items.Clear();

            // Limpiar el campo de entrada
            txtNumero.Clear();
            txtNumero.Focus();

            // Saltar Mensaje para verificar que a sido destruido
            MessageBox.Show("El árbol ha sido destruido y todos los datos han sido eliminados.", "Árbol Destruido", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
