// Ustvari knjižnico razredov (dll) z imenom CDteka (tako naj bo tudi ime namespacea). Vsebuje naj razreda CD in Skladba:
//
// CDji naj imajo naslednje podatke:
// naslov
// band
// zvrst
// steviloSkladb
// skladbe (polje skladb, za katerega od deklaraciji ustvariš le referenco (ne uporabiš new), v konstruktorju pa ustvariš polje z new in ob tem določiš dolžino polja (število pesmi).
//
//         Skladbe imajo naslednje podatke:
// naslov
// avtorGlasbe
// avtorBesedila
// dolzinaVSekundah
//
//     Podatki razredov Skladba in CD naj bodo privatni, metode (sam presodi, katere so tiste, ki jih boš sprogramiral) pa javne. Za oba razreda ustvari ustrezne javne lastnosti.
//     V razredu CD v konstruktorjih in ustreznih metodah kontroliraj število pesmi, ki mora biti med 1 in 50. Če je manjše, ga popravi na 1, če je večje pa na 50, v razredu Skladba pa dolžino skladbe, ki mora biti med 1 in 5000s. V konstruktorjih jo popravi (če je manjša jo nastavi na 1, če je večja pa na 5000), v lastnosti pa pri napačni dolžini ohrani že nastavljeno.
//     Da boš lahko uporabil razrede iz knjižnice, je najprej v projektu, kjer je glavni program potrebno dodati referenco na projekt s knjižnico (Add Reference, zavihek Projects: to je mogoče v projektu, ki je del iste rešitve(solution) kot knjižnica)ali na samo .dll datoteko (Add Reference, zavihek Browse; bolj splošen način, saj deluje tudi v projektih iz drugih rešitev).
// Program naj omogoča vpis toliko CDjev, kolikor jih bo določil uporabnik. CDji naj bodo shranjeni v polju objektov razreda CD. Ko bodo CDji vpisani, naj program izpiše vse podatke o vseh CDjih, nato pa še kateri CD je najdaljši in kateri najkrajši (po lastnem izboru sprogramiraj ali metodo ali lastnost Dolzina ali pa statična podatka najdaljsi in najkrajsi).


using CDteka;

class Naloga04
{
    static void Main()
    {
        Console.Write("Koliko CDjev? ");
        int stCD = int.Parse(Console.ReadLine());

        CD[] cdji = new CD[stCD];

        for (int i = 0; i < stCD; i++)
        {
            Console.WriteLine($"\n=== CD {i + 1} ===");

            Console.Write("Naslov: ");
            string naslov = Console.ReadLine();

            Console.Write("Band: ");
            string band = Console.ReadLine();

            Console.Write("Zvrst: ");
            string zvrst = Console.ReadLine();

            Console.Write("Število skladb: ");
            int stSkladb = int.Parse(Console.ReadLine());

            cdji[i] = new CD(naslov, band, zvrst, stSkladb);

            for (int j = 0; j < cdji[i].SteviloSkladb; j++)
            {
                Console.WriteLine($"Skladba {j + 1}:");

                Console.Write("Naslov: ");
                string naslovSkladbe = Console.ReadLine();

                Console.Write("Avtor glasbe: ");
                string avtorG = Console.ReadLine();

                Console.Write("Avtor besedila: ");
                string avtorB = Console.ReadLine();

                Console.Write("Dolžina (s): ");
                int dolzina = int.Parse(Console.ReadLine());

                cdji[i].Skladbe[j] = new Skladba(naslovSkladbe, avtorG, avtorB, dolzina);
            }
        }

        Console.WriteLine("\n\n=== VSI CDji ===");
        for (int i = 0; i < stCD; i++)
        {
            Console.WriteLine($"\nCD {i + 1}: {cdji[i].Naslov}");
            Console.WriteLine($"Band: {cdji[i].Band}");
            Console.WriteLine($"Zvrst: {cdji[i].Zvrst}");
            Console.WriteLine($"Dolžina: {cdji[i].Dolzina()}s");
            Console.WriteLine("Skladbe:");

            for (int j = 0; j < cdji[i].SteviloSkladb; j++)
            {
                if (cdji[i].Skladbe[j] != null)
                {
                    Console.WriteLine($"{j + 1}. {cdji[i].Skladbe[j].Naslov} " + $"({cdji[i].Skladbe[j].DolzinaVSekundah}s)");
                }
            }
        }

        int najdaljsi = 0, najkrajsi = 0;
        for (int i = 1; i < stCD; i++)
        {
            if (cdji[i].Dolzina() > cdji[najdaljsi].Dolzina())
                najdaljsi = i;
            if (cdji[i].Dolzina() < cdji[najkrajsi].Dolzina())
                najkrajsi = i;
        }

        Console.WriteLine($"\nNajdaljši CD: {cdji[najdaljsi].Naslov} ({cdji[najdaljsi].Dolzina()}s)");
        Console.WriteLine($"Najkrajši CD: {cdji[najkrajsi].Naslov} ({cdji[najkrajsi].Dolzina()}s)");
    }
}
