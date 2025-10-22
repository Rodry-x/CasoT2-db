
namespace CasoT2_db.Estructura_De_Datos
{
    internal class NodoABN
    {
        // -- Atributos del Arbol Binario -- //
        private int valor;
        private NodoABN? izquierdo;
        private NodoABN? derecho;

        // -- Constructor del Arbol Binario -- //
        public NodoABN(int valor)
        {
            this.valor = valor;
            izquierdo = null;
            derecho = null;
        }

        // -- Getters y Setters del Arbol Binario -- //
        public int Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public NodoABN? Izquierdo
        {
            get { return izquierdo; }
            internal set { izquierdo = value; }
        }

        public NodoABN? Derecho
        {
            get { return derecho; }
            internal set { derecho = value; }
        }
    }
}
