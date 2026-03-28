// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

using Obligatorisk_Oppgave_1;

public class Program
{

    //legg inn alle lister som brukes av hele programmet her:
    static List<Kurs> KursListe = new List<Kurs>();   
    static List<Student> Studenter = Student.DefaultStudent();     //må ha en måte å legge til studenter på, og en måte å se hvilke studenter som er oppmeldt på kurs   
    static Bibliotek bibliotek = new Bibliotek();


    private static void Main(string[] args)
    {

        Meny meny = new Meny();

        bool kjører = true;

        while (kjører)      
        {
            meny.VisMeny();

            string valg = Console.ReadLine();

            switch (valg)
            {
                case "1":
                    KursService.OpprettKurs(KursListe);
                    break;

                case "2":
                    KursService.MeldPåEllerAvStudent();
                    break;

                case "3":
                    KursService.SkrivUtKursOgStudentInfo();
                    break;

                case "4":
                    KursService.SøkKurs();
                    break;

                case "5":
                    bibliotek.SøkBok(bøker);
                    break;

                case "6":
                    bibliotek.LånUt();      //må sende bok + låner
                    break;

                case "7":
                    bibliotek.Returner();
                    break;

                case "8":
                    bibliotek.RegistrerBok();
                    break;

                case "0":
                    return;
            }
        }

        //---------------KURS-------------------

        void OpprettKurs(KursService allekurs)
        {
            Console.Write("Kode: ");
            string kurskode = Console.ReadLine();

            Console.Write("Navn: ");
            string kursnavn = Console.ReadLine();

            Console.Write("Studiepoeng: ");
            int studiepoeng = int.Parse(Console.ReadLine());

            Console.Write("Maks plasser: ");
            int maksAntallPlasser = int.Parse(Console.ReadLine());

            KursListe.Add(new Kurs(kurskode, kursnavn, studiepoeng, maksAntallPlasser));
        }

       static void MeldPåEllerAvStudent(KursService system)
        {
            Console.Write("Student ID: ");
            int studentID = int.Parse(Console.ReadLine());

            Console.Write("Kurs kode: ");
            string kurskode = Console.ReadLine();

            Student student = Studenter.FirstOrDefault(s => s.StudentID == studentID);
            Kurs kurs = KursListe.FirstOrDefault(k => k.KursKode == kurskode);

            if (student != null && kurs != null)
            {
                if (kurs.HarLedigPlass())
                {
                    kurs.Studenter.Add(student);
                    Console.WriteLine("Student meldt på.");
                }
                else
                {
                    Console.WriteLine("Kurset er fullt.");
                }

            }
        }

        static void PrintKurs()
        {
            foreach (var kurs in KursListe)
            {
                Console.WriteLine(kurs.KursKode + " - " + kurs.KursNavn);

                foreach (var student in kurs.Studenter)
                {
                    Console.WriteLine("  " + student.Navn);
                }
            }
        }

        void SøkKurs()
        {
            Console.Write("Søk: ");
            string søk = Console.ReadLine();

            var resultat = KursListe
                .Where(k => k.KursKode.Contains(søk) || k.KursNavn.Contains(søk));

            foreach (var kurs in resultat)
            {
                Console.WriteLine(kurs.KursKode + " - " + kurs.KursNavn);
            }
        }

        //-----------------BIBLIOTEK-----------------

        void RegistrerBok()
        {
            Console.Write("ID: ");
            int bokID = int.Parse(Console.ReadLine());

            Console.Write("Tittel: ");
            string tittel = Console.ReadLine() ?? string.Empty;

            Console.Write("Forfatter: ");
            string forfatter = Console.ReadLine() ?? string.Empty;

            Console.Write("År: ");
            int år = int.Parse(Console.ReadLine());

            Console.Write("Antall: ");
            int antall = int.Parse(Console.ReadLine());

            Bøker.Add(new Bok(bokID, tittel, forfatter, år, antall));
        }

        void SøkBok()
        {
            Console.Write("Søk tittel: ");
            string søk = Console.ReadLine();
            bibliotek.SøkBok(søkBok)

            var resultat = Bøker.Where(b => b.Tittel.Contains(søk, StringComparison.OrdinalIgnoreCase));

            foreach (var bok in resultat)
            {
                Console.WriteLine($"{bok.Tittel} ({bok.Antall} stk)");
            }
        }

        void LånBok(Bok bok, Bruker bruker)
        {
            Console.Write("Bok ID: ");
            int bokID = int.Parse(Console.ReadLine());

            bok = bøker.FirstOrDefault(b => b.BokID == bokID);

            if (bok != null && bok.Antall > 0)      
            {
                bibliotek.LånUt(bok, bruker);
                Console.WriteLine("Bok lånt ut.");
            }
            else
            {
                Console.WriteLine("Ingen eksemplarer tilgjengelig.");
            }
           
        }

        void Returner()
        {
            Console.Write("Bok ID: ");
            int bokID = int.Parse(Console.ReadLine());

            Bok bok = Bøker.FirstOrDefault(b => b.BokID == bokID);

            if (bok != null)
            {
                bibliotek.Returner(bok);
                Console.WriteLine("Bok returnert.");
            }
        }
    }
}