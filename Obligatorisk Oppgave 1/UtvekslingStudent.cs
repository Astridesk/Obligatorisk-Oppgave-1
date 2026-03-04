using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class UtvekslingsStudent : Student
    {
        public string HjemUniversitet { get; set; } = string.Empty;
        public string HjemLand { get; set; } = string.Empty;
        public string Periode { get; set; } = string.Empty;
        public UtvekslingsStudent(string navn, string epost, int studentID, string kurs, string hjemUniversitet, string hjemLand, string periode) : base(navn, epost, studentID, kurs)
        {
            HjemUniversitet = hjemUniversitet;
            HjemLand = hjemLand;
            Periode = periode;
        }
    }
}
