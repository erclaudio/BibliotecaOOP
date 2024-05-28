using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class DVD : Documento
    {
        public int DurataMin { get; set; }

        public DVD() { }

        public DVD(int Durata)
        {
            DurataMin = Durata;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nDurataMin: {DurataMin}";
        }
        



    }
}
