using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Student : Bruker
    {
        public int StudentID { get; set; }
        public string Kurs { get; set; } = string.Empty;        //skal det være en Liste?

        public Student (string navn, string epost, int studentID, string kurs) : base(navn, epost)
        {
            StudentID = studentID;
            Kurs = kurs;
        }
    }
}
