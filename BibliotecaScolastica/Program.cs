using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BibliotecaScolastica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Biblioteca biblioteca = new Biblioteca("Biblioteca Centrale", "Via Roma 1", DateTime.Parse("08:00"), DateTime.Parse("18:00"));

            string continua = "s";
            while (continua.ToLower() == "s")
            {
                Console.WriteLine("Benvenuti nella Biblioteca Scolastica!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Scegliere azione:");
                Console.WriteLine("1. Aggiungi Libro");
                Console.WriteLine("2. Cerca Libro per Titolo");
                Console.WriteLine("3. Cerca Libri per Autore");
                Console.WriteLine("4. Calcola Numero di Libri");
                Console.Write("Azione (1-4): ");
                string choice = Console.ReadLine();
                Console.WriteLine("Operazione selezionata: " + choice);
                Console.WriteLine("--------------------------------------");

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Inserisci Autore: (Nome e Cognome)");
                        string autore = Console.ReadLine();
                        Console.WriteLine("Inserisci Titolo:");
                        string titolo = Console.ReadLine();
                        Console.WriteLine("Inserisci Anno di Pubblicazione (YYYY-MM-DD):");
                        DateTime annoDiPubblicazione;
                        if (!DateTime.TryParse(Console.ReadLine(), out annoDiPubblicazione))
                        {
                            Console.WriteLine("Data non valida. Operazione annullata.");
                            break;
                        }
                        Console.WriteLine("Inserisci Editore:");
                        string editore = Console.ReadLine();
                        Console.WriteLine("Inserisci Numero di Pagine:");
                        int numeroDiPagine;
                        if (!int.TryParse(Console.ReadLine(), out numeroDiPagine))
                        {
                            Console.WriteLine("Numero di pagine non valido. Operazione annullata.");
                            break;
                        }
                        Libro nuovoLibro = new Libro(autore, titolo, annoDiPubblicazione, editore, numeroDiPagine);
                        biblioteca.AggiungiLibro(nuovoLibro);
                        Console.WriteLine("Libro aggiunto: " + nuovoLibro);
                        Console.WriteLine("Vuoi calcolare il tempo di lettura? (s/n)");
                        string calcolaTempo = Console.ReadLine();
                        if (calcolaTempo.ToLower() == "s")
                        {
                            int tempoLettura = nuovoLibro.readingTime();
                            Console.WriteLine("Tempo stimato di lettura: " + tempoLettura + " ora/e");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Inserisci Titolo del Libro da Cercare:");
                        string titoloCercato = Console.ReadLine();
                        Libro libroTrovato = biblioteca.RicercaLibro(titoloCercato);
                        if (libroTrovato != null)
                            Console.WriteLine("Libro trovato: " + libroTrovato);
                        else
                            Console.WriteLine("Libro non trovato.");
                        break;
                    case "3":
                        Console.WriteLine("Inserisci Autore dei Libri da Cercare:");
                        string autoreCercato = Console.ReadLine();
                        List<Libro> libriTrovati = biblioteca.RicercaLibroDaAutore(autoreCercato);
                        if (libriTrovati.Count > 0)
                        {
                            Console.WriteLine("Libri trovati:");
                            foreach (var libro in libriTrovati)
                            {
                                Console.WriteLine(libro);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nessun libro trovato per l'autore specificato.");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Numero totale di libri nella biblioteca: " + biblioteca.CalcolaNumeroLibri());
                        break;
                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }

                Console.WriteLine("Vuoi eseguire un'altra operazione? (s/n)");
                continua = Console.ReadLine();
            }
        }
    }
}
