namespace CasoT2_db.Estructura_De_Datos
{
    internal class ArbolBinarioNum
    {
        // -- Raíz del árbol -- //
        private NodoABN? raiz;

        // --- Inserta un nuevo valor en el árbol binario de búsqueda --- //
        public void Insertar(int nuevoValor)
        {
            if (raiz == null)
            {
                raiz = new NodoABN(nuevoValor);
                return;
            }

            InsertarRec(raiz, nuevoValor);
        }

        // --- Inserción recursiva --- //
        private void InsertarRec(NodoABN nodo, int nuevoValor)
        {
            // -- si nuevoValor < nodo.Valor va a la izquierda -- //
            if (nuevoValor < nodo.Valor)
            {
                if (nodo.Izquierdo == null)
                {
                    nodo.Izquierdo = new NodoABN(nuevoValor);
                }

                // -- llamada recursiva -- //
                else
                {
                    InsertarRec(nodo.Izquierdo, nuevoValor);
                }
            }

            // -- si nuevoValor > nodo.Valor va a la derecha -- //
            else if (nuevoValor > nodo.Valor)
            {
                if (nodo.Derecho == null)
                {
                    nodo.Derecho = new NodoABN(nuevoValor);
                }

                // -- llamada recursiva -- //
                else
                {
                    InsertarRec(nodo.Derecho, nuevoValor);
                }
            }
            // si es igual, no se inserta (evitar duplicados). Cambia según necesidad.
        }

        // Buscar por Preorden (raíz, izquierda, derecha)
        public List<int> PreOrden()
        {
            var resultado = new List<int>();
            PreOrdenRec(raiz, resultado);
            return resultado;
        }

        private void PreOrdenRec(NodoABN? nodo, List<int> lista)
        {
            if (nodo == null) return;
            lista.Add(nodo.Valor);
            PreOrdenRec(nodo.Izquierdo, lista);
            PreOrdenRec(nodo.Derecho, lista);
        }

        // Buscar por Inorden (izquierda, raíz, derecha)
        public List<int> InOrden()
        {
            var resultado = new List<int>();
            InOrdenRec(raiz, resultado);
            return resultado;
        }

        private void InOrdenRec(NodoABN? nodo, List<int> lista)
        {
            if (nodo == null) return;
            InOrdenRec(nodo.Izquierdo, lista);
            lista.Add(nodo.Valor);
            InOrdenRec(nodo.Derecho, lista);
        }

        // Buscar por Postorden (izquierda, derecha, raíz)
        public List<int> PostOrden()
        {
            var resultado = new List<int>();
            PostOrdenRec(raiz, resultado);
            return resultado;
        }

        private void PostOrdenRec(NodoABN? nodo, List<int> lista)
        {
            if (nodo == null) return;
            PostOrdenRec(nodo.Izquierdo, lista);
            PostOrdenRec(nodo.Derecho, lista);
            lista.Add(nodo.Valor);
        }

        // Método auxiliar: vacía el árbol
        public void Clear()
        {
            raiz = null;
        }

        // Método auxiliar: obtiene la raíz
        public NodoABN? GetRaiz() => raiz;

        // Método auxiliar: indica si está vacío
        public bool IsEmpty() => raiz == null;      
    }
}
