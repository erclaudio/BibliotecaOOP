using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Persona
    {
        public string Nome {  get; set; }
        public string Cognome { get; set; }
        public List<Prestito> Prestiti { get; set; }

        public Persona () 
        {
            Prestiti = new List<Prestito>();
        }
        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
            Prestiti = new List<Prestito>();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nome: {Nome}");
            sb.AppendLine($"Cognome: {Cognome}");
            sb.AppendLine("Prestiti:");

            foreach (var prestito in Prestiti)
            {
                sb.AppendLine(prestito.ToString());
            }

            return sb.ToString();
        }
        public void AddPrestito(Prestito prestito)
        {
            this.Prestiti.Add(prestito);
        }
        
        
    }
}
