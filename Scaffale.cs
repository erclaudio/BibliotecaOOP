using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Scaffale
    {
        public string ScaffaleNr {  get; set; }
        public List<Documento> documenti { get; set; }

   

        public Scaffale() { documenti = new List<Documento>(); }

        public Scaffale(string numero) {
            ScaffaleNr = numero;
            documenti = new List<Documento>();

        }
        public void AddDocumentoScaffale(Documento documento) { documenti.Add(documento);}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ScaffaleNr);
            foreach (var documento in documenti)
            {
                sb.AppendLine(documento.ToString());
            }

            return sb.ToString();

        }


        
    }
}
