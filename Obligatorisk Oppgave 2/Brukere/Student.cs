using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_2
{
    public class Student : Bruker
    {
        public int StudentID { get; init; }
        public Dictionary<Kurs, string> Karakterer { get; } = new();        //med dictionary kan student ha flere kurs og karakterer.
        public List<Kurs> KursListe { get; } = new();

        public Student(string navn, string epost, string brukernavn, string passord, int studentID)
        {
            Navn = navn;
            Epost = epost;
            Brukernavn = brukernavn;
            Passord = passord;
            StudentID = studentID;
            Rolle = Rolle.Student;
        }

        //Default studenter

        
    }
}
