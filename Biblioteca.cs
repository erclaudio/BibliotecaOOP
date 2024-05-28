using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Biblioteca
{
    internal class Biblioteca
    {
        public string Nome {  get; set; }
        public List<Documento> DocumentiBiblio { get;set; }
        public List<Utente> Utenti { get; set; }
        public Biblioteca(string Nome) 
        {
            this.Nome = Nome;
            DocumentiBiblio = new List<Documento>();
            Utenti = new List<Utente>();
        }
        public void AddDocumet(Documento documento)
        {
            this.DocumentiBiblio.Add(documento);
        }
        public Documento SearchDocumentByKey(string Uniquekey)
        {
            return this.DocumentiBiblio.Find(x=>x.UniqieKey == Uniquekey);
        }
        public void AddUser(Utente user)
        {
            this.Utenti.Add(user);
        }
        public Documento SearchDocumentByTitle(string titolo)
        {
            return this.DocumentiBiblio.Find(x=>x.Titolo == titolo);
        }
        public string SearchByName(string email)
        {
            Utente trovato = this.Utenti.Find(x => x.Email == email);
            return trovato.ToString();
        }
    }
}
