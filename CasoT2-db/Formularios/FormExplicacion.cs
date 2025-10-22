
using CasoT2_db.Utilidades;

namespace CasoT2_db.Formularios
{
    public partial class FormExplicacion : Form
    {
        public FormExplicacion()
        {
            InitializeComponent();
        }

        private FormPrincipal formPrincipal;
        private FormExplicacion2 formExplicacion2;

        public Panel PanelExplicacion => panelExplicacion;

        private void cambiarAlPanelPrincipal(object sender, EventArgs e)
        {
            formPrincipal = new FormPrincipal();
            PanelController.CambiarPanel(panelExplicacion, formPrincipal.PanelPrincipal);
        }

        private void abrirLinkDelDiagrama_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://drive.google.com/file/d/1__UAb-U5Vwu3ms-R87gTVjfRpdo3eCz4/view?usp=drive_link");
        }

        private void abrirElVideo_PreInPostOrden_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://drive.google.com/file/d/1-LXjo4f7W8ePCNoOktrgFCP5rO9SlpVF/view?usp=drive_link");
        }

        private void cambiarAlPanelExplicacion2_Click(object sender, EventArgs e)
        {
            formExplicacion2 = new FormExplicacion2();
            PanelController.CambiarPanel(panelExplicacion, formExplicacion2.PanelExplicacion2);
        }

        private void abrirElVideo_Ejemplo1_Click(object sender, EventArgs e)
        {
            AbrirUrl.AbrirEnNavegador("https://drive.google.com/file/d/1X2u7__lCrGvREgI4uhtUNF7ssIcxKtqB/view?usp=drive_link");
        }
    }
}
