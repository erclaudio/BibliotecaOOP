using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Autore : Persona
    {
        public List<Documento> Documenti { get; set; }        
        
        public Autore() 
        {
            Documenti = new List<Documento>();
        }

        public void AddDocumentoAuore(Documento documento) 
        {
            this.Documenti.Add(documento);
        }






    }
}
