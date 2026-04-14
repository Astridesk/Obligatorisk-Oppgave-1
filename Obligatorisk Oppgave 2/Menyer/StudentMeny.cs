using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_2.Menyer
{
    public class StudentMeny : MenyBase
    {
        public override void Vis()
        {
            Console.WriteLine("\n--- Studentmeny ---");

            Console.WriteLine("[1] Søk på kurs");
            Console.WriteLine("[2] Meld deg på/av kurs");          //kan den melde seg av?
            Console.WriteLine("[3] Se oppmeldte kurs");
            Console.WriteLine("[4] Se karakterer");

            Console.WriteLine("[5] Søk på bok");
            Console.WriteLine("[6] Lån bok");
            Console.WriteLine("[7] Returner bok");

            Console.WriteLine("[0] Logg ut");
        }

        public override bool BehandleValg(string valg, Bruker innlogget)
        {
            var student = innlogget as Student;
            if (student == null)
            {
                Console.WriteLine("Feil: ikke student.");
                return false;
            }

            switch (valg)
            {
                case "1":
                    Kurs.SøkKurs();
                    break;
                case "2":
                    Program.MeldPåEllerAvStudent(student);
                    break;
                case "3":
                    Kurs.VisStudentKurs(student);
                    break;
                case "4":
                    Kurs.VisStudentKarakterer(student);
                    break;
                case "5":
                    Program.bibliotek.SøkBok();
                    break;
                case "6":
                    Program.LånBok(student);
                    break;
                case "7":
                    Program.Returner(student);
                    break;
                case "0":
                    return false;
                default:
                    Console.WriteLine("Ugyldig valg.");
                    break;
            }
            return true;
        }
    }

}
