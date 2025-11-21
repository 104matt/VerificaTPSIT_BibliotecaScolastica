using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        public string Autore { get; private set; }
        public string Titolo { get; private set; }
        public DateTime AnnoDiPubblicazione { get; private set; }
        public string Editore { get; private set; }
        public int NumeroDiPagine { get; private set; }

    }
}
