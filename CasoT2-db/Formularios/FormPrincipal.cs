
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
        private FormExplicacion1 formExplicacion1;

        private void cambiarAlPanelArbolBB(object sender, EventArgs e)
        {
            formArbolBB = new FormArbolBB();
            PanelController.CambiarPanel(panelPrincipal, formArbolBB.PanelArbol);
        }

        private void cambiarAlPanelExplicacion(object sender, EventArgs e)
        {
            formExplicacion1 = new FormExplicacion1();
            PanelController.CambiarPanel(panelPrincipal, formExplicacion1.PanelExplicacion1);
        }
    }
}
