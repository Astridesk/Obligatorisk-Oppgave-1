using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Student : Bruker
    {
        public int StudentID { get; init; }     

        public Student(string navn, string epost, int studentID)
        {
            StudentID = studentID;
            Navn = navn;
            Epost = epost;
        }

        //Default studenter

        public static List<Student> DefaultStudent()
        {
            return new List<Student>
            {
                new Student("Ola Nordmann", "ola.nordmann@uia.no", 12345)
            };
        }
    }
}
