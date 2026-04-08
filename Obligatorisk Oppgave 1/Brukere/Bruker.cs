using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public abstract class Bruker  
    {
        //instansvariabler
        public string Navn { get; set; }       //sett som protected?
        public string Epost { get; set; }
        public string BrukerNavn { get; private set; }
        public string Passord { private get; set; }

    }
}

