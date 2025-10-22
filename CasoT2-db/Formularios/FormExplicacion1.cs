using CasoT2_db.Utilidades;

namespace CasoT2_db.Formularios
{
    public partial class FormExplicacion1 : Form
    {
        public FormExplicacion1()
        {
            InitializeComponent();
        }
        private FormPrincipal formPrincipal;
        private FormExplicacion formExplicacion;
        public Panel PanelExplicacion1 => panelExplicacion1;

        private void cambiarAlPanelExplicacion(object sender, EventArgs e)
        {
            formExplicacion = new FormExplicacion();
            PanelController.CambiarPanel(panelExplicacion1, formExplicacion.PanelExplicacion);
        }

        private void cambiarAlPanelPrincipal(object sender, EventArgs e)
        {
            formPrincipal = new FormPrincipal();
            PanelController.CambiarPanel(panelExplicacion1, formPrincipal.PanelPrincipal);
        }

        private void abriElVideoExplicacionPDF_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://www.loom.com/share/38e941dd7e2e49ccb14c3d971c6d6b38?sid=f77e8868-529d-46b5-9cae-fd4279ab5959");
        }

        private void abrirDescargaPDF_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://drive.google.com/file/d/1-G10avpilOZ-MUs8fN4HCxnkutZY7XrL/view?usp=sharing");
        }
    }
}
