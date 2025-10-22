
using CasoT2_db.Utilidades;

namespace CasoT2_db.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        // Propiedad para acceder al panel principal
        public Panel PanelPrincipal => panelPrincipal;

        // Instancias de los formularios secundarios
        private FormArbolBB formArbolBB;
        private FormExplicacion formExplicacion;


        private void cambiarAlPanelArbolBB(object sender, EventArgs e)
        {
            formArbolBB = new FormArbolBB();
            PanelController.CambiarPanel(panelPrincipal, formArbolBB.PanelArbol);
        }

        private void cambiarAlPanelExplicacion(object sender, EventArgs e)
        {
            formExplicacion = new FormExplicacion();
            PanelController.CambiarPanel(panelPrincipal, formExplicacion.PanelExplicacion);
        }
    }
}
