using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave_1
{
    public class Bibliotek
    {
        List<Bok> Bøker = new List<Bok>();
        List<Bruker> Brukere = new List<Bruker>();
        List<BibliotekLån> LånListe = new List<BibliotekLån>();

        public void RegistrerBok(Bok bok)
        {
            Bøker.Add(bok);
            Console.WriteLine("Boken er registrert i biblioteket.");
        }

        public void RegistrerBruker(Bruker bruker)
        {
            Brukere.Add(bruker);
            Console.WriteLine("Brukeren er registrert i biblioteket.");
        }



        public void LånUtBok(Bok bok, Bruker bruker)       //Liten bok er et objekt?
        {
            if (bok.Ledig())
            {
                bok.LånUt();

                BibliotekLån biblioteklån = new BibliotekLån(bok, bruker);

                Console.WriteLine("Boken er lånt ut.");
            }
            else
            {
                Console.WriteLine("Boken er ikke tilgjengelig for utlån.");
            }


        }

        public void LeverInnBok(Bok bok)
        {
            foreach (var biblioteklån in LånListe)
            {
                if (biblioteklån.Bok == bok && biblioteklån.ReturneringsDato == null)
                {
                    biblioteklån.ReturneringsDato = DateTime.Now;
                    bok.Returner();
                    Console.WriteLine("Boken er levert inn.");
                    return;
                }
            }
        }

        public void VisAktiveLån()
        {
            Console.WriteLine("Aktive lån:");
            foreach (var biblioteklån in LånListe)
            {
                if (biblioteklån.ReturneringsDato == null)
                {
                    Console.WriteLine($"Bok: {biblioteklån.Bok.Tittel}, Lånt av: {biblioteklån.Bruker.Navn}, Lånedato: {biblioteklån.LåneDato}");
                }
            }
        }
        public void VisHistorikk()
        {
            Console.WriteLine("Lånehistorikk:");
            foreach (var biblioteklån in LånListe)
            {
                //Sjekk denne
                Console.WriteLine($"Bok: {biblioteklån.Bok.Tittel}, Lånt av: {biblioteklån.Bruker.Navn}, Lånedato: {biblioteklån.LåneDato}, " +
                    $"Returnert: {(biblioteklån.ReturneringsDato.HasValue ? biblioteklån.ReturneringsDato.Value.ToString() : "Ikke returnert")}");
            }
        }
    }
}
