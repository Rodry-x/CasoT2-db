using System;
using System.Collections.Generic;

namespace CasoT2_db.Estructura_De_Datos
{
    internal class Ejercicio1ABB
    {
        private NodoEjercicioABB? raiz;

        public void Insertar(int codigo, string nombre)
        {
            if (raiz == null)
            {
                raiz = new NodoEjercicioABB(codigo, nombre);
                return;
            }
            InsertarRec(raiz, codigo, nombre);
        }

        private void InsertarRec(NodoEjercicioABB nodo, int codigo, string nombre)
        {
            if (codigo < nodo.Codigo)
            {
                if (nodo.Izquierdo == null)
                {
                    nodo.Izquierdo = new NodoEjercicioABB(codigo, nombre);
                }
                else
                {
                    InsertarRec(nodo.Izquierdo, codigo, nombre);
                }
            }
            else if (codigo > nodo.Codigo)
            {
                if (nodo.Derecho == null)
                {
                    nodo.Derecho = new NodoEjercicioABB(codigo, nombre);
                }
                else
                {
                    InsertarRec(nodo.Derecho, codigo, nombre);
                }
            }
        }

        // Devuelve una cadena con los elementos en InOrden (mantengo tu formato)
        public string MostrarInOrden()
        {
            return MostrarInOrdenRec(raiz).TrimEnd(',', ' ');
        }

        private string MostrarInOrdenRec(NodoEjercicioABB? nodo)
        {
            if (nodo == null) return string.Empty;
            string resultado = string.Empty;
            resultado += MostrarInOrdenRec(nodo.Izquierdo);
            resultado += $"{nodo.Codigo}-{nodo.Nombre}, ";
            resultado += MostrarInOrdenRec(nodo.Derecho);
            return resultado;
        }

        // Devuelve la lista InOrden como pares (codigo, nombre)
        public List<(int Codigo, string Nombre)> ObtenerInOrden()
        {
            var lista = new List<(int, string)>();
            ObtenerInOrdenRec(raiz, lista);
            return lista;
        }

        private void ObtenerInOrdenRec(NodoEjercicioABB? nodo, List<(int Codigo, string Nombre)> lista)
        {
            if (nodo == null) return;
            ObtenerInOrdenRec(nodo.Izquierdo, lista);
            lista.Add((nodo.Codigo, nodo.Nombre));
            ObtenerInOrdenRec(nodo.Derecho, lista);
        }

        // Buscar nodo por código (devuelve el nodo o null si no existe)
        public NodoEjercicioABB? BuscarPorCodigo(int codigo)
        {
            return BuscarPorCodigoRec(raiz, codigo);
        }

        private NodoEjercicioABB? BuscarPorCodigoRec(NodoEjercicioABB? nodo, int codigo)
        {
            if (nodo == null) return null;
            if (codigo == nodo.Codigo) return nodo;
            return codigo < nodo.Codigo
                ? BuscarPorCodigoRec(nodo.Izquierdo, codigo)
                : BuscarPorCodigoRec(nodo.Derecho, codigo);
        }

        // Método auxiliar: busca el nombre por código (null si no existe)
        public string? BuscarNombrePorCodigo(int codigo)
        {
            var nodo = BuscarPorCodigo(codigo);
            return nodo?.Nombre;
        }
    }
}
