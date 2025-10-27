// Ustvari nov projekt Geometrija mu takoj dodaj nov razred kot samostojen modul (v Solution Explorerju desno
// klikni na projekt Geometrija in izberi Add / Class in ga poimenuj LikiFormule Iz datoteke zbriši vse (using, namespace) razen razreda.
// Doseži, da bo razred statičen. To pomeni, da bodo tudi vsi elementi razreda statični in da ne bomo mogli ustvariti primerkov tega razreda.
// Dodaj javen konstanten podatek PI (3.14).
// Dodaj javne metode PloscinaKvadrata, ObsegKvadrata, PloscinaPravokotnika, ObsegPravokotnika, PloscinaKroga,
// ObsegKroga, PloscinaTrikotnika in ObsegTrikotnika. Metode naj imajo tiste parametre, ki jih potrebujemo za izračune,
// metoda za izračun ploščine trikotnika pa naj bo preobložena, da bo omogočala izračun po več formulah (vsaj z višino in Heronovim obrazcem).
// V glavnem programu izračunaj in izpiši nekaj ploščin in obsegov.


class Naloga02
{
    static void Main()
    {
        Console.WriteLine($"PI = {LikiFormule.PI}");

        Console.WriteLine($"\nKvadrat (a=5):");
        Console.WriteLine($"Ploščina: {LikiFormule.PloscinaKvadrata(5)}");
        Console.WriteLine($"Obseg: {LikiFormule.ObsegKvadrata(5)}");

        Console.WriteLine($"\nPravokotnik (a=4, b=6):");
        Console.WriteLine($"Ploščina: {LikiFormule.PloscinaPravokotnika(4, 6)}");
        Console.WriteLine($"Obseg: {LikiFormule.ObsegPravokotnika(4, 6)}");

        Console.WriteLine($"\nKrog (r=3):");
        Console.WriteLine($"Ploščina: {LikiFormule.PloscinaKroga(3)}");
        Console.WriteLine($"Obseg: {LikiFormule.ObsegKroga(3)}");

        Console.WriteLine($"\nTrikotnik (a=5, ha=4):");
        Console.WriteLine($"Ploščina: {LikiFormule.PloscinaTrikotnika(5, 4)}");

        Console.WriteLine($"\nTrikotnik (a=3, b=4, c=5):");
        Console.WriteLine($"Ploščina (Heron): {LikiFormule.PloscinaTrikotnika(3, 4, 5)}");
        Console.WriteLine($"Obseg: {LikiFormule.ObsegTrikotnika(3, 4, 5)}");
    }
}
