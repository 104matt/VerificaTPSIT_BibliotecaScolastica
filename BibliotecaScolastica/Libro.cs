using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        public string Autore { get; set; }
        public string Titolo { get; set; }
        public DateTime AnnoDiPubblicazione { get; set; }
        public string Editore { get; set; }
        public int NumeroDiPagine { get; set; }

        public Libro(string autore, string titolo, DateTime annoDiPubblicazione, string editore, int numeroDiPagine)
        {
            Autore = autore;
            Titolo = titolo;
            AnnoDiPubblicazione = annoDiPubblicazione;
            Editore = editore;
            NumeroDiPagine = numeroDiPagine;
        }

        public override string ToString()
        {
            return $"{Autore}, {Titolo}, {AnnoDiPubblicazione}, {Editore}, {NumeroDiPagine}";
        }

        public int readingTime()
        {
            return NumeroDiPagine < 100 ? 1 : -1;
        }

    }
}
