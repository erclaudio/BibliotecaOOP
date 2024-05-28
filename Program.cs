using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inizializzazione 
            #region
            Biblioteca DaEma_Cla = new Biblioteca("Da Ema & Cla");
            Prestito prestito = new Prestito {
            Numero = "01",
            Inizio = new DateTime(2024,10,1),
            Fine = new DateTime(2025,2,11)
            };
            Prestito prestito2 = new Prestito
            {
                Numero = "02",
                Inizio = new DateTime(2024, 10, 1),
                Fine = new DateTime(2025, 2, 11)
            };
            Autore aut1 = new Autore
            {
                Nome = "Cesare",
                Cognome = "Leopardi"                

            };            
            Utente user1 = new Utente
            {
                Nome = "Giorgio",
                Cognome = "ErBello",
                Telefono = "3334445566",
                Email = "giorgio.erbello@developer.net",
                Pass = "artemis01"
            };
            DVD dvd1 = new DVD
            {
                UniqieKey = "01",
                Titolo = "Giorgio Nei Prati",
                Anno = 2052,
                Settore = "Thriller",
                DurataMin = 34

            };
            Libro libro1 = new Libro
            {
                UniqieKey = "02",
                Titolo = "Perche' la Bibbia e' una truffa",
                Anno = 2025,
                Settore = "Scienza",
                NumPagine = 666
            };
            Scaffale libriScienza = new Scaffale("Scienza");
            Scaffale filmThriller = new Scaffale("Thriller");
            #endregion
            // Configurazione Biblioteca, Documenti, Autori e Utenti
            #region
            libriScienza.AddDocumentoScaffale(libro1);
            filmThriller.AddDocumentoScaffale(dvd1);
            libro1.AddAutore(aut1);
            aut1.AddDocumentoAuore(libro1);
            DaEma_Cla.AddDocumet(dvd1);
            DaEma_Cla.AddDocumet(libro1);
            DaEma_Cla.AddUser(user1);
            prestito.AddDocument(dvd1);
            prestito2.AddDocument(dvd1);
            user1.AddPrestito(prestito);
            #endregion





            //ricerca tramite numero
            Documento documentotramitenumero = DaEma_Cla.SearchDocumentByKey("01");
            Console.WriteLine("\n"+documentotramitenumero);
            //ricerca tramite titolo
            Documento documentotramitetitolo = DaEma_Cla.SearchDocumentByTitle("Perche' la Bibbia e' una truffa");
            Console.WriteLine("\n"+documentotramitetitolo);
            //ricerca tramite utente
            Console.WriteLine("\n"+DaEma_Cla.SearchByName("giorgio.erbello@developer.net"));
            Console.WriteLine("Scaffale: " + libriScienza.ToString());
            Console.WriteLine("Scaffale: " + filmThriller.ToString());
            /*
            DaEma_Cla.AddDocumet(dvd1);
            Documento documento = DaEma_Cla.SearchDocument("01");
            Console.WriteLine(documento);
            */
            Console.ReadLine();

        }
    }
}
