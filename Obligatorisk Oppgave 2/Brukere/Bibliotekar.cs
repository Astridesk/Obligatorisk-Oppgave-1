using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_2
{
    public class Bibliotekar : Ansatt     
    {
        public Bibliotekar(string navn, string epost, string brukernavn, string passord,
                       int ansattID, string stilling, string avdeling)
        : base(navn, epost, brukernavn, passord, ansattID, stilling, avdeling)
        {
            Rolle = Rolle.Bibliotekar;
        }
    }
}

