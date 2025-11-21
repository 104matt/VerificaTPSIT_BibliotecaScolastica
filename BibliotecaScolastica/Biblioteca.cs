using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        public string Nome { get; set; }
        public string Indirizzo { get; set; }
        public DateTime OrarioApertura { get; set; }
        public DateTime OrarioChiusura { get; set; }
        public List<Libro> LibriDisponibili { get; set; }

        public Biblioteca(string nome, string indirizzo, DateTime orarioApertura, DateTime orarioChiusura)
        {
            Nome = nome;
            Indirizzo = indirizzo;
            OrarioApertura = orarioApertura;
            OrarioChiusura = orarioChiusura;
            LibriDisponibili = new List<Libro>();
        }

        public void AggiungiLibro(Libro libro)
        {
            LibriDisponibili.Add(libro);
        }

        public Libro RicercaLibro(string titolo)
        {
            if (string.IsNullOrWhiteSpace(titolo))
                return null;

            for (int i = 0; i < LibriDisponibili.Count; i++)
            {
                var libro = LibriDisponibili[i];
                if (libro != null && string.Equals(libro.Titolo, titolo, StringComparison.OrdinalIgnoreCase))
                    return libro;
            }

            return null;
        }

    }
}
