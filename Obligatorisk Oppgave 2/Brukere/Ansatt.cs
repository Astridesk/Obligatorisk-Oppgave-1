using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_2
{
    public class Ansatt : Bruker
    {
        public int AnsattID { get; set; }
        public string Stilling { get; set; }
        public string Avdeling { get; set; }

        public Ansatt(string navn, string epost, string brukernavn, string passord,
                  int ansattID, string stilling, string avdeling)
        {
            Navn = navn;
            Epost = epost;
            Brukernavn = brukernavn;
            Passord = passord;
            AnsattID = ansattID;
            Stilling = stilling;
            Avdeling = avdeling;
            Rolle = Rolle.Ansatt;
        }

        
    }
}
