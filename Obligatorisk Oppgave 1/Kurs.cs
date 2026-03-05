using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Kurs
    {
        public string KursKode { get; set; } = string.Empty;
        public string KursNavn { get; set; } = string.Empty;
        public int Studiepoeng { get; set; }
        public int MaksPlasser { get; set; }

        List <Student> Deltakere = new List<Student>();

    }
}
