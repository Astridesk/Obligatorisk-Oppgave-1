using Obligatorisk_Oppgave_2;

public class BibliotekarMeny : MenyBase
{
    public override void Vis()
    {
        Console.WriteLine("\n--- Bibliotekarmeny ---");
        Console.WriteLine("[1] Søk på bok");
        Console.WriteLine("[2] Lån bok");
        Console.WriteLine("[3] Returner bok");
        Console.WriteLine("[4] Registrer bok");
        Console.WriteLine("[5] Vis aktive lån");
        Console.WriteLine("[6] Vis historikk");
        Console.WriteLine("[0] Logg ut");
    }

    public override bool BehandleValg(string valg, Bruker innlogget)
    {
        switch (valg)
        {
            case "1":
                Program.bibliotek.SøkBok();
                break;
            case "2":
                Program.LånBok(innlogget);
                break;
            case "3":
                Program.Returner(innlogget);
                break;
            case "4":
                Program.bibliotek.RegistrerBokFraMeny();
                break;
            case "5":
                Program.bibliotek.VisAktiveLån();
                break;
            case "6":
                Program.bibliotek.VisHistorikk();
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
