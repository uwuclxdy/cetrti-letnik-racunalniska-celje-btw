// Ustvari nov projekt DeloZLiki.
// Uporabi modul LikiFormule iz prejšnje naloge (desni klik na projekt DeloZLiki v Solution Explorerju / Add /Existing Item,
// nato pa splezamo do datoteke LikiFormule.cs. Izbrana datoteka se kopira v mapo trenutnega projekta in se prikaže v Solution
// Explorerju. Pozor, zdaj imamo dve neodvisni datoteki LikiFormule.cs. Če spremenimo eno, moramo tudi drugo, če želimo,
// da sta usklajeni.
// Projektu dodaj nov modul za delo z liki Liki.cs (lahko dodamo novo datoteko s kodo, lažje pa bo, da dodamo nov razred,
// v resnici jih bomo imeli v tej datoteki več).
// V novi datoteki naj ne bo namespaceov.
// V njej ustvari štiri razrede: Krog, Trikotnik, Kvadrat in Pravokotnik.
// Vsak od razredov naj ima potrebne privatne podatke (npr. Krog r, Trikotnik a, b in c …)
// Krog in Trikotnik naj imata še javna, samo bralna (readonly) podatka ploscina in obseg, Tako bosta na voljo tudi izven
// razreda, ne bo pa se ju dalo popravljati (razen ob deklaraciji in v konstruktorjih). V glavnem programu preizkusi,
// ali to drži. Napiši privzeti, pretvorbeni in kopirni konstruktor, pri privzetem podatke nastavi na smiselne podatke
// po lastnem izboru, pri pretvorbenem preveri smiselnost podatkov (če so podatki negativna števila jih nastavi na 0).
// Poleg osnovnih podatkov nastavi tudi podatka ploscina in obseg, tako da uporabiš metode razreda LikiFormule.
// Pri Kvadratu in Pravokotniku  pa se namesto samo bralnih podatkov odločimo za samo bralne lastnosti. Tega ne moremo
// naredi z rezervirano besedo readonly ampak tako, da definiramo le get del lastnosti, set del pa izpustimo. Lastnosti
// Ploscina in Obseg naj za izračun uporabita ustrezne metode iz razreda LikiFormule in naj bosta javni. Tako bomo lahko
// tudi izven razreda izpisali oboje, nastavljanje pa ne bo mogoče (preveri v glavnem programu, OPOMBA: če bi želeli imeti
// v razredu možnost nastavljanja obeh vrednosti, izven razreda pa ne, bi to storili tako, da bi set del deklarirali kot privaten).
// Napiši privzeti, pretvorbeni in kopirni konstruktor, pri prvih dveh preverjaj smiselnost podatkov (če so podatki negativna
// števila jih nastavi na 0).
// V glavnem programu projekta DeloZLiki ustvari nekaj objektov zgornjih razredov in izpiši njihove ploščine in obsege.


class Naloga03
{
    static void Main()
    {
        Console.WriteLine("=== KROG ===");
        var k1 = new Krog();
        var k2 = new Krog(5);
        Console.WriteLine($"k1: ploščina={k1.ploscina}, obseg={k1.obseg}");
        Console.WriteLine($"k2: ploščina={k2.ploscina}, obseg={k2.obseg}");

        // Poskus spreminjanja readonly polja (ne bo delovalo):
        // k2.ploscina = 100; // Napaka pri prevajanju!

        Console.WriteLine("\n=== TRIKOTNIK ===");
        var t1 = new Trikotnik();
        var t2 = new Trikotnik(3, 4, 5);
        Console.WriteLine($"t1: ploščina={t1.ploscina}, obseg={t1.obseg}");
        Console.WriteLine($"t2: ploščina={t2.ploscina}, obseg={t2.obseg}");

        Console.WriteLine("\n=== KVADRAT ===");
        var kv1 = new Kvadrat();
        var kv2 = new Kvadrat(6);
        Console.WriteLine($"kv1: Ploscina={kv1.Ploscina}, Obseg={kv1.Obseg}");
        Console.WriteLine($"kv2: Ploscina={kv2.Ploscina}, Obseg={kv2.Obseg}");

        // Poskus spreminjanja readonly lastnosti (ne bo delovalo):
        // kv2.Ploscina = 100; // Napaka pri prevajanju!

        Console.WriteLine("\n=== PRAVOKOTNIK ===");
        var p1 = new Pravokotnik();
        var p2 = new Pravokotnik(4, 7);
        Console.WriteLine($"p1: Ploscina={p1.Ploscina}, Obseg={p1.Obseg}");
        Console.WriteLine($"p2: Ploscina={p2.Ploscina}, Obseg={p2.Obseg}");
    }
}
