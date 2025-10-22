
using CasoT2_db.Utilidades;

namespace CasoT2_db.Formularios
{
    public partial class FormExplicacion2 : Form
    {
        public FormExplicacion2()
        {
            InitializeComponent();
        }

        private FormExplicacion formExplicacion;
        public Panel PanelExplicacion2 => panelExplicacion2;

        private void cambiarAlPanelExplicacion(object sender, EventArgs e)
        {
            formExplicacion = new FormExplicacion();
            PanelController.CambiarPanel(panelExplicacion2, formExplicacion.PanelExplicacion);
        }

        private void abrirElVideo_ExplicandoCodigoEjemplo1_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://drive.google.com/file/d/1TqmbSEbw_EFPjOn3wGcuvm831JqCqIrC/view?usp=sharing");
        }

        private void verDiapositiva_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://prezi.com/view/eB9zgrSbEt0PiqHkinej/?referral_token=qANHITlnB3FN");
        }
    }
}
