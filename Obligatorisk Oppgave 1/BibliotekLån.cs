using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class BibliotekLån
    {
        public Bok Bok { get; set; }
        public Bruker Bruker { get; set; }

        public DateTime LåneDato { get; set; }
        public DateTime? ReturneringsDato { get; set; }

        public BibliotekLån(Bok bok, Bruker bruker)
        {
            Bok = bok;
            Bruker = bruker;
            LåneDato = DateTime.Now;
        }


    }
}
