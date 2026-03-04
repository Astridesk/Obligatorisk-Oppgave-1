using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Ansatt : Bruker
    {
        public int AnsattID { get; set; }
        public string Stilling { get; set; } = string.Empty;
        public string Avdeling { get; set; } = string.Empty;
        public Ansatt(string navn, string epost, int ansattID, string stilling, string Avdeling) : base(navn, epost)        //Hva betyr denne linjen??
        {
            AnsattID = ansattID;
            Stilling = stilling;
        }
    }
}
