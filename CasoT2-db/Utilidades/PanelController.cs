
namespace CasoT2_db.Utilidades
{
    internal static class PanelController
    {
        // --- Método para cambiar el contenido entre los paneles --- //
        public static void CambiarPanel(Panel panelContenedor, Panel nuevoPanel)
        {
            panelContenedor.Controls.Clear();
            nuevoPanel.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(nuevoPanel);
        }
    }
}
