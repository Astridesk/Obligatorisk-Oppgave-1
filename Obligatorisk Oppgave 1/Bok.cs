using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Bok : ILånerOgGirTilbake
    {
        public string BokID { get; set; } = string.Empty;
        public string Tittel { get; set; } = string.Empty;
        public string Forfatter { get; set; } = string.Empty;
        public string År { get; set; } = string.Empty;
        public int Antall { get; set; }
        public int Ledige { get; set; }

        public Bok(string bokID, string tittel, string forfatter, string år,  int antall)
            {
                BokID = bokID;
                Tittel = tittel;
                Forfatter = forfatter;
                År = år;
                Antall = antall;
                Ledige = antall;
        }

        public bool Ledig()
        {
            return Ledige > 0;
        }

        public void LånUt()
        {
            if (Ledig())
            {
                Ledige--;
            }
            
        }

        public void Returner()
        {
            Ledige++;
        }
        public string SkrivUtInfo()
        {
            return $"BokID: {BokID} \nTittel: {Tittel} \nForfatter: {Forfatter} \nÅr: {År} \nAntall Eksemplarer: {Ledige}";
        }
    }
}
