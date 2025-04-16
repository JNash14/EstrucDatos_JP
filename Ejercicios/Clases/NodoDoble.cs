using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios.Clases
{
    internal class NodoDoble
    {
        private int numero;
        private string nombre;         //se usara este campo para analisis
        private byte edad;             //se usara este campo para analisis (byte almacena de cero a 255)
        private NodoDoble siguiente;
        private NodoDoble anterior;

        public int Numero { get => numero; set => numero = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public byte Edad { get => edad; set => edad = value; }
        internal NodoDoble Siguiente { get => siguiente; set => siguiente = value; }
        internal NodoDoble Anterior { get => anterior; set => anterior = value; }
    }
}
