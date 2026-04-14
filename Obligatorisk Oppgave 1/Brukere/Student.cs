//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Text;

//namespace Obligatorisk_Oppgave_1
//{
//    public class Student : Bruker
//    {
//        public int StudentID { get; init; }
//        public Dictionary<Kurs, string> Karakterer { get; } = new();
//        public List<Kurs> KursListe { get; } = new();

//        public Student(string navn, string epost, int studentID)
//        {
//            Navn = navn;
//            Epost = epost;          
          
//            StudentID = studentID;
            
//        }

//        //Default studenter

//        public static List<Student> DefaultStudent()
//        {
//            return new List<Student>
//            {
//                new  ("Ola Nordmann", "ola.nordmann@uia.no", 12345 /*karakter*/ )
//            };
//        }
//    }
//}
