namespace CasoT2_db.Estructura_De_Datos
{
    internal class NodoEjercicioABB
    {
        private int codigo;
        private string nombre;
        private NodoEjercicioABB? izquierdo;
        private NodoEjercicioABB? derecho;

        // Constructor cambiado a 'internal' para permitir su uso desde Ejercicio1ABB
        internal NodoEjercicioABB(int codigo, string nombre)
        {
            this.codigo = codigo;
            this.nombre = nombre ?? string.Empty;
            izquierdo = null;
            derecho = null;
        }

        // --- Getters y Setters -- //
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value ?? string.Empty; }
        }

        public NodoEjercicioABB? Izquierdo
        {
            get { return izquierdo; }
            internal set { izquierdo = value; }
        }

        public NodoEjercicioABB? Derecho
        {
            get { return derecho; }
            internal set { derecho = value; }
        }
    }
}
