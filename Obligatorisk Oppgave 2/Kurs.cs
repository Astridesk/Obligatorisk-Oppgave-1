using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; // Add this at the top with other using statements

namespace Obligatorisk_Oppgave_2
{
    //Inneholder Kurs-klassen og defaultkurs.
    //
    public class Kurs
    {
        public string KursKode { get; set; }
        public string KursNavn { get; set; }
        public int Studiepoeng { get; set; }
        public int MaksAntallPlasser { get; set; }

        public List<Student> Studenter { get; private set; } = new();
        public List<Bok> Pensum { get; set; } = new();
        public Dictionary<Student, string> Karakterer { get; set; } = new();




        public Kurs(string kurskode, string kursnavn, int studiepoeng, int maksAntallPlasser)
        {
            KursKode = kurskode;
            KursNavn = kursnavn;
            Studiepoeng = studiepoeng;
            MaksAntallPlasser = maksAntallPlasser;

        }

        public static List<Kurs> KursListe()      //må ha antall ledige plasser
        {
            return new List<Kurs>
            {
                new Kurs("IS-110", "Objektorientert programmering", 10, 30),
                new Kurs("IS-105", "Datasystemer og systemarkitektur", 10, 30)
            };
        }



        public bool HarLedigPlass()
        {
            return Studenter.Count < MaksAntallPlasser;
        }

        public bool LeggTilStudent(Student student)
        {
            if (!HarLedigPlass()) return false;
            if (Studenter.Contains(student)) return false;

            Studenter.Add(student);
            student.KursListe.Add(this);
            return true;
        }

        public bool MeldAvStudent(Student student)
        {
            if (!Studenter.Contains(student)) return false;
            Studenter.Remove(student);
            student.KursListe.Remove(this);
            return true;
        }

        public static void SøkKurs()
        {
            Console.Write("Søk: ");
            string søk = Console.ReadLine();

            var resultat = KursListe()
                .Where(k => k.KursKode.Contains(søk) || k.KursNavn.Contains(søk));

            foreach (var kurs in resultat)
            {
                Console.WriteLine(kurs.KursKode + " - " + kurs.KursNavn);
            }
        }
        public static void SkrivUtKursOgStudentInfo()
        {
            foreach (var kurs in KursListe())
            {
                Console.WriteLine(kurs.KursKode + " - " + kurs.KursNavn);

                foreach (var student in kurs.Studenter)
                {
                    Console.WriteLine(student.Navn);
                }
            }
        }
        public static void VisStudentKurs(Student student)
        {
            if (student.KursListe.Count == 0)
            {
                Console.WriteLine("Du er ikke meldt opp i noen kurs.");
                return;
            }

            Console.WriteLine("\n--- Dine kurs ---");
            foreach (var kurs in student.KursListe)
            {
                Console.WriteLine($"{kurs.KursKode} - {kurs.KursNavn}");
            }
        }

        public static void VisStudentKarakterer(Student student)
        {
            if (student.Karakterer.Count == 0)
            {
                Console.WriteLine("Du har ingen registrerte karakterer.");
                return;
            }

            Console.WriteLine("\n--- Dine karakterer ---");
            foreach (var entry in student.Karakterer)
            {
                Kurs kurs = entry.Key;
                string karakter = entry.Value;

                Console.WriteLine($"{kurs.KursKode} - {kurs.KursNavn}: {karakter}");
            }
        }
        public static void RegistrerPensum(List<Kurs> kursListe, List<Bok> bøker)
        {
            Console.Write("Kurskode: ");
            string kode = Console.ReadLine();

            var kurs = kursListe.FirstOrDefault(k => k.KursKode == kode);
            if (kurs == null)
            {
                Console.WriteLine("Fant ikke kurs.");
                return;
            }

            Console.Write("Bok ID: ");
            if (!int.TryParse(Console.ReadLine(), out int bokID))
            {
                Console.WriteLine("Ugyldig bok ID.");
                return;
            }

            var bok = bøker.FirstOrDefault(b => b.BokID == bokID);
            if (bok == null)
            {
                Console.WriteLine("Fant ikke bok.");
                return;
            }

            if (!kurs.Pensum.Contains(bok))
            {
                kurs.Pensum.Add(bok);
                Console.WriteLine("Bok lagt til som pensum.");
            }
            else
            {
                Console.WriteLine("Boken er allerede registrert som pensum.");
            }
        }
        public static void SettKarakter(List<Kurs> kursListe, List<Student> studenter)
        {
            Console.Write("Kurskode: ");
            string kode = Console.ReadLine();

            var kurs = kursListe.FirstOrDefault(k => k.KursKode == kode);
            if (kurs == null)
            {
                Console.WriteLine("Fant ikke kurs.");
                return;
            }

            Console.Write("Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int studentID))
            {
                Console.WriteLine("Ugyldig ID.");
                return;
            }

            var student = studenter.FirstOrDefault(s => s.StudentID == studentID);
            if (student == null)
            {
                Console.WriteLine("Fant ikke student.");
                return;
            }

            Console.Write("Karakter: ");
            string karakter = Console.ReadLine();

            kurs.Karakterer[student] = karakter;
            student.Karakterer[kurs] = karakter;

            Console.WriteLine("Karakter registrert.");
        }



    }
}
