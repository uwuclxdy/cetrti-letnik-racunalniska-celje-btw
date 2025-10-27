// Na koncu prejšnjih vaj smo ustvarili dve verziji razreda Datum. Obe smo shranili v samostojni datoteki, ustvarili smo torej dva modula. Iz modula (ali tudi več modulov) lahko ustvarimo dinamično knjižnico (dll). Če uporabimo slednjo, izvorne kode v C# sploh ne potrebujemo več, rabimo le .dll datoteko in sklic nanjo v programu, ki jo bo uporabil.
// Ustvari dinamično knjižnico v projektu z imenom Datum_TriStevila
// Za to ob ustvarjanju projekta izberi tip Class Library. Uporabi kodo razreda Datum iz prejšnjih vaj in sicer verzijo, ki za predstavitev datuma uporablja tri cela števila (naloga 6).
// Ker boš razred uporabljali v drugih programih (assemblyjih), mora biti javen (spredaj dopiši public, saj je privzeto zaseben).
// Razred naj ne bo v nobenem namespace-u.
// V Solutin Explorerju v Properties na prvi kartici spremeni ime assembly-ja v Datum. To pomeni, da bo prevedena knjižnica imenovana Datum.dll (torej drugače kot se imenuje projekt).
// Prevedi projekt (pazi, z F5 ali s Ctrl F5 ne bo šlo, saj projekt ni izvršljiv, potrebno je uporabiti Build). Rezultat je dinamična knjižnica, datoteka Datum.dll, ki se nahaja v DatumTriStevila\bin\Debug in ki jo lahko uporabimo v novih projektih.
//
// Nato ustvari nov projekt Datum_Knjiznice, ki bo uporabljal Datum.dll iz projekta Datum_TriStevila.
// Za glavni program uporabi kar kodo, ki si jo uporabil v glavnem programu pri prejšnjih vajah (naloga 6).
// Kopiraj datoteko Datum.dll iz projekta Datum_TriStevila v mapo projekta Datum_Knjiznice.
// Da boš lahko uporabil razred Datum iz knjižnice, je najprej v projektu, kjer je glavni program potrebno dodati sklic na projekt s knjižnico (Add Reference, npr. z desnim klikom na projekt v Solution Explorer ali prek menija Project, zavihek Projects: to je mogoče v projektu, ki je del iste rešitve(solution) kot knjižnica) ali na samo .dll datoteko (Add Reference, zavihek Browse; bolj splošen način, saj deluje tudi v projektih iz drugih rešitev). Mi bomo uporabili drug način.
// Ko program prevedemo in poženemo, Visual Studio sam prekopira tudi. dll datoteko v mapo, kjer je .exe datoteka (v nekaterih prejšnjih verzijah Visual Studia je bilo to drugače).
// Program lahko zdaj zaženemo tako iz Visual Studia kot z dvoklikom nanj v Raziskovalcu.
//
// Zdaj pa bi radi demonstrirali koristnost kapsuliranja in sicer tako, da bomo ustvarili nov Datum.dll, ki bo za predstavitev datuma uporabljal DateTime in ga uporabili z ž obsoječim programom (.exe datotekao), ne da bi bilo potrebno ta program ponovno prevesti. Pogoj za to je, da se nov .dll datoteka imenuje enako kot prejšnja (Datum.dll) in da sta obe .dll datoteki »navzven« povsem enaki, kaj se skriva »znotraj kapsule« ni pomebno:
// ustvari novo knjižnico Datum_DateTime, uporabi kodo iz prejšnjih vaj (naloga 7), pazi, da bo razred javen
// prevedii knjižnico tako, da se bo imenovala Datum.dll (Solution Explorer / Properties / Assemly Name v lastnostih projekta)
// kopiraj novi dll k .exe datoteki iz projekta Datum_Knjižnice tako, da povozimo starega
// projekta Datum_Knjižnice NE prevajaj ponovno, uporabili bomo staro kodo, le da bo ta zdaj uporabljala novi .dll
// v Raziskovalcu z dvoklikom poženi .exe program iz projekta Datum_Knjižnice
//
// Če smo vse naredili prav, se mora program uspešno izvesti.


class Naloga01
{
    static void Main()
    {
        var d1 = new Datum();
        var d2 = new Datum(28, 2, 2024);
        var d3 = new Datum(d2);

        Console.WriteLine($"Prestopno leto? {d2.JeLetoPrestopno()}");

        d2.PovecajDatum();
        d2.Izpisi();
        d2.PovecajDatum(5);
        d2.Izpisi();

        d3.PomanjsajDatum();
        d3.Izpisi();
        d3.PomanjsajDatum(10);
        d3.Izpisi();

        d1.DanVTednu();

        var d4 = new Datum(5, 7, 2024);
        d4.Izpisi("d.m.llll");
        d4.Izpisi("d.mmm.llll");
        d4.Izpisi("dd.mm.ll");

        Datum.Izpisi(d4, "d.mmm.llll");

        Console.WriteLine($"Število datumov: {Datum.StDatumov}");
    }
}
