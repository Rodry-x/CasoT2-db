using System;
using System.Collections.Generic;

namespace CasoT2_db.Estructura_De_Datos
{
    internal class ArboBinarioPregunta
    {
        // -- Raíz del árbol -- //
        private NodoABP? raiz;

        // --- Listas donde se guardan las preguntas y respuestas "Si" y "No" --- //
        private readonly List<string> preguntasSi = new();
        private readonly List<string> preguntasNo = new();

        // -- Limpiando las listas de respuestas -- //
        public void ClearRespuestas()
        {
            preguntasSi.Clear();
            preguntasNo.Clear();
        }

        public void ClearAll()
        {
            raiz = null;
            ClearRespuestas();
        }

        // Busca recursivamente la primera coincidencia de la pregunta
        // Compara ignorando mayúsculas/minúsculas.
        public NodoABP? BuscarRec(NodoABP nodo, string pregunta)
        {
            if (nodo == null) return null;

            // Comparación segura (ignorar diferencia de mayúsculas)
            if (string.Equals(nodo.Pregunta, pregunta, StringComparison.OrdinalIgnoreCase))
            {
                return nodo;
            }

            // Buscar en la rama "Si" (izquierda)
            NodoABP? encontrado = null;
            if (nodo.Si != null)
            {
                encontrado = BuscarRec(nodo.Si, pregunta);
                if (encontrado != null) return encontrado;
            }

            // Buscar en la rama "No" (derecha)
            if (nodo.No != null)
            {
                encontrado = BuscarRec(nodo.No, pregunta);
            }

            return encontrado;
        }

        // Registra la respuesta para una pregunta concreta.
        // Si el árbol está vacío crea la raíz con esa pregunta.
        // La función añade la pregunta a la lista correspondiente (Si/No) evitando duplicados.
        // Devuelve true si se registró la respuesta, false si no (por ejemplo, entrada nula).
        public bool RegistrarRespuesta(string pregunta, bool respuestaSi)
        {
            if (pregunta == null) return false;

            // Si no hay árbol, creamos la raíz con la primera pregunta encontrada
            if (raiz == null)
            {
                raiz = new NodoABP(pregunta);
            }

            // (Opcional) buscar en el árbol: si no existe, no se añade como nodo automáticamente
            // Pero siempre registramos la respuesta en las listas para poder mostrar resultados.
            // Evitar duplicados en las listas:
            if (respuestaSi)
            {
                if (!preguntasSi.Contains(pregunta, StringComparer.OrdinalIgnoreCase))
                {
                    preguntasSi.Add(pregunta);
                }

                // Si estaba en la lista de "No", eliminarla para mantener coherencia
                preguntasNo.RemoveAll(p => string.Equals(p, pregunta, StringComparison.OrdinalIgnoreCase));
            }
            else
            {
                if (!preguntasNo.Contains(pregunta, StringComparer.OrdinalIgnoreCase))
                {
                    preguntasNo.Add(pregunta);
                }

                // Si estaba en la lista de "Si", eliminarla
                preguntasSi.RemoveAll(p => string.Equals(p, pregunta, StringComparison.OrdinalIgnoreCase));
            }

            return true;
        }

        public List<string> ObtenerPreguntasSi() => new List<string>(preguntasSi);
        public List<string> ObtenerPreguntasNo() => new List<string>(preguntasNo);
    }
}
