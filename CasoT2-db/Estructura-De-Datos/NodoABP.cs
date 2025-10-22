using System;

namespace CasoT2_db.Estructura_De_Datos
{
    internal class NodoABP
    {
        // Texto de la pregunta guardada en el nodo
        private string pregunta;
        private NodoABP? izquierdo; // hijo "Si"
        private NodoABP? derecho;   // hijo "No"

        // Constructor del nodo con la pregunta
        public NodoABP(string pregunta)
        {
            this.pregunta = pregunta ?? string.Empty;
            izquierdo = null;
            derecho = null;
        }

        // Getters y Setters
        public string Pregunta
        {
            get { return pregunta; }
            set { pregunta = value ?? string.Empty; }
        }

        // Hijos: Izquierdo representa la rama "Si", Derecho la rama "No"
        public NodoABP? Si
        {
            get { return izquierdo; }
            internal set { izquierdo = value; }
        }

        public NodoABP? No
        {
            get { return derecho; }
            internal set { derecho = value; }
        }
    }
}
