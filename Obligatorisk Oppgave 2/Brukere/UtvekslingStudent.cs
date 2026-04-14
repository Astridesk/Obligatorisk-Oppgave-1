using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_2
{
    public class UtvekslingsStudent : Student
    {
        public string HjemUniversitet { get; set; }
        public string HjemLand { get; set; }
        public string Periode { get; set; }        //(fra-til)

        public UtvekslingsStudent(
            string navn,
            string epost,
            string brukernavn,
            string passord,
            int studentID,
            string hjemuniversitet,
            string hjemland,
            string periode)
            : base(navn, epost, brukernavn, passord, studentID)
        {
            HjemUniversitet = hjemuniversitet;
            HjemLand = hjemland;
            Periode = periode;
        }

        public static List<UtvekslingsStudent> DefaultUtvekslingsStudenter()
        {
            return new List<UtvekslingsStudent>
                {
                    new UtvekslingsStudent(
                        "Itachi Uchiha",
                        "itachi.uchiha@uia.no",
                        "itachi.uchiha",
                        "defaultPass",
                        54321,
                        "University of Konohagakure",
                        "Land of Fire",
                        "høst 2026-vår2027")
                };
        }
    }
}
