using System;
using System.Collections.Generic;
using System.Text;

namespace PilasListas
{
    internal class Pilas
    {
        private List<string> _pila;

        public Pilas()
        {

            _pila = new List<string>();
        }
        public void Agregar(string dato)
        {
            _pila.Add(dato);
        }

        public void Eliminar()
        {
            if (_pila.Count == 0)
            {
                throw new Exception("La pila está vacía.");
            }
            _pila.RemoveAt(_pila.Count - 1 );
        }

        public string ObtenerDatos()
        {
            StringBuilder datos = new StringBuilder();
            foreach (string dato in _pila)
            {
                datos.AppendLine(dato);
            }
            return datos.ToString();
        }
    }
}
