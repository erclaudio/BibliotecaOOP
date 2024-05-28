using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Documento
    {
        public string UniqieKey { get; set; }
        public string Titolo { get; set; }

        public int Anno { get; set; }

        public string Settore { get; set; }

        public bool Occupato { get; set; }
        public List<Autore> Autori { get; set; }


        public Documento() 
        {

            Autori = new List<Autore>();
        }
        public Documento(string Uniqiekey, string titolo, int anno, string settore)
        {
            UniqieKey = Uniqiekey;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Occupato = false;
            Autori = new List<Autore>();
        }

        public override string ToString()
        {
            return $"Codice: {UniqieKey}" + 
                $"\nTitolo: {Titolo}" + 
                $"\nAnno: {Anno}" + 
                $"\nSettore: {Settore}" +
                $"\nOccupato: {Occupato}";
        }
        public void ImpostaPrestito()
        {
            Occupato = true;
        }
        public void ImpostaDisponibile()
        {
            Occupato = false;
        }
        
    }
}
