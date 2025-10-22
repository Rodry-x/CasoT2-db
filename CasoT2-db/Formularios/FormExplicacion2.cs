
using CasoT2_db.Utilidades;

namespace CasoT2_db.Formularios
{
    public partial class FormExplicacion2 : Form
    {
        public FormExplicacion2()
        {
            InitializeComponent();
        }
        private FormArbolPregunta formArbolPregunta;
        private FormExplicacion formExplicacion;
        public Panel PanelExplicacion2 => panelExplicacion2;

        private void cambiarAlPanelExplicacion(object sender, EventArgs e)
        {
            formExplicacion = new FormExplicacion();
            PanelController.CambiarPanel(panelExplicacion2, formExplicacion.PanelExplicacion);
        }

        private void cambiandoAlPanelArbolPregunta_Click(object sender, EventArgs e)
        {
            formArbolPregunta = new FormArbolPregunta();
            PanelController.CambiarPanel(panelExplicacion2, formArbolPregunta.PanelABB2);
        }

        private void abrirElVideo_ExplicandoCodigoEjemplo1_Click(object sender, EventArgs e)
        {
            // AbrirUrl.AbrirEnNavegador("Poner la URL del video acá");
        }
    }
}
