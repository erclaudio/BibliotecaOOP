using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Libro : Documento
    {
        public int NumPagine { get; set; }

        public Libro() { }

        public Libro(int numPagine)
        {
            NumPagine = numPagine;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNumPagine: {NumPagine}";
        }
        public void AddAutore(Autore autore)
        {
            this.Autori.Add(autore);
        }

    }
}
