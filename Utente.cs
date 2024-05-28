using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Utente : Persona
    {
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pass { get; set; }
        public Utente() { }
        public Utente(string telefono, string email, string pass)
        {
            Telefono = telefono;
            Email = email;
            Pass = pass;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Telefono: {Telefono}");
            sb.AppendLine($"Email: {Email}");
            
            return sb.ToString();

        }
    }
}
