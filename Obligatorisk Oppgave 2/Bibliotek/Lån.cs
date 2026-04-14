using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_2
{
    public class Lån
    {
        public Bruker Låner { get; set; }
        public Bok Bok { get; set; }
        public DateTime LåneDato { get; init; }
        public bool Returnert { get; set; }
        public DateTime? ReturDato { get; set; }
        public Lån(Bruker låner, Bok bok)
        {
            Låner = låner;
            Bok = bok;
            LåneDato = DateTime.Now; 
            Returnert = false;
        }
    }
}
