using System;
using System.Windows.Forms;
using CasoT2_db.Utilidades;
using CasoT2_db.Estructura_De_Datos;

namespace CasoT2_db.Formularios
{
    public partial class FormArbolPregunta : Form
    {
        public FormArbolPregunta()
        {
            InitializeComponent();
        }

        private FormExplicacion2 formExplicacion2;

        public Panel PanelABB2 => panelABB2;

        // Instancia del árbol de preguntas (gestiona registro de S/N)
        private readonly ArboBinarioPregunta arbolPreguntas = new();

        private void cambiarAlPanelArbolBB_Click(object sender, EventArgs e)
        {
            formExplicacion2 = new FormExplicacion2();
            PanelController.CambiarPanel(panelABB2, formExplicacion2.PanelExplicacion2);
        }

        // Actualiza los ListView con las listas actuales del árbol
        private void ActualizarListas()
        {
            listViewPreguntasSi.Items.Clear();
            listViewPreguntasNo.Items.Clear();

            foreach (var p in arbolPreguntas.ObtenerPreguntasSi())
            {
                listViewPreguntasSi.Items.Add(new ListViewItem(p));
            }

            foreach (var p in arbolPreguntas.ObtenerPreguntasNo())
            {
                listViewPreguntasNo.Items.Add(new ListViewItem(p));
            }
        }

        // Pregunta 1
        private void pregunta1_Si_Click(object sender, EventArgs e)
        {
            var pregunta = lblPregunta1.Text ?? "Pregunta 1";
            arbolPreguntas.RegistrarRespuesta(pregunta, true);
            ActualizarListas();
        }

        private void pregunta1_No_Click(object sender, EventArgs e)
        {
            var pregunta = lblPregunta1.Text ?? "Pregunta 1";
            arbolPreguntas.RegistrarRespuesta(pregunta, false);
            ActualizarListas();
        }

        // Pregunta 2
        private void pregunta2_Si_Click(object sender, EventArgs e)
        {
            var pregunta = lblPregunta2.Text ?? "Pregunta 2";
            arbolPreguntas.RegistrarRespuesta(pregunta, true);
            ActualizarListas();
        }

        private void pregunta2_No_Click(object sender, EventArgs e)
        {
            var pregunta = lblPregunta2.Text ?? "Pregunta 2";
            arbolPreguntas.RegistrarRespuesta(pregunta, false);
            ActualizarListas();
        }

        // Pregunta 3
        private void pregunta3_Si_Click(object sender, EventArgs e)
        {
            var pregunta = lblPregunta3.Text ?? "Pregunta 3";
            arbolPreguntas.RegistrarRespuesta(pregunta, true);
            ActualizarListas();
        }

        private void pregunta3_No_Click(object sender, EventArgs e)
        {
            var pregunta = lblPregunta3.Text ?? "Pregunta 3";
            arbolPreguntas.RegistrarRespuesta(pregunta, false);
            ActualizarListas();
        }

        // Borra todas las respuestas y el árbol (si se desea) y limpia las listas
        private void eliminarArbolBinario_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Deseas eliminar todas las respuestas?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            arbolPreguntas.ClearAll();
            ActualizarListas();
        }
    }
}
