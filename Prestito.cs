using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Prestito
    {
        public string Numero {  get; set; }
        public DateTime Inizio { get; set; }
        public DateTime Fine { get; set; }
        public List<Documento> Documenti { get; set; }
        public Prestito() {
            Documenti = new List<Documento>();
        }
        public Prestito(string numero, DateTime inizio, DateTime fine)
        {
            Numero = numero;
            Inizio = inizio;
            Fine = fine;
            Documenti = new List<Documento>();  
        }

        public override string ToString()
        {
            return base.ToString()+$"Numero: {Numero}" +
                $"\nInizio: {Inizio}" +
                $"\nFine: {Fine}";
        }
        public void AddDocument(Documento documento)
        {
            if (documento.Occupato == false)
            {
                this.Documenti.Add(documento);
                documento.Occupato = true;
            }
            else { Console.WriteLine("Documento Occupato"); }
        }
    }
}
