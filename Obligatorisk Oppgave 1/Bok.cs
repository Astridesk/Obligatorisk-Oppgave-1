using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Bok
    {
        public string BokID { get; set; } = string.Empty;
        public string Tittel { get; set; } = string.Empty;
        public string Forfatter { get; set; } = string.Empty;
        public string År { get; set; } = string.Empty;
        public int AntallEksemplarer { get; set; }

        public string SkrivUtInfo()
        {
            return $"BokID: {BokID} \nTittel: {Tittel} \nForfatter: {Forfatter} \nÅr: {År} \nAntall Eksemplarer: {AntallEksemplarer}";
        }
    }
}
