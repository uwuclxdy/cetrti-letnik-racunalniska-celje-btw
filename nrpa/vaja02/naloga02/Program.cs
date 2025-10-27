// V novem projektu ustvari novo verzijo datuma Datum_v2, ki naj ima poleg treh javnih
// podatkov še tri konstruktorje: privzetega (brez parametra, datum naj nastavi na trenutni
// datum), pretvorbenega, ki prejme dan, mesec in leto kot tri cela števila in iz njih tvori
// nov datum ter kopirnega, ki nov objekt ustvari kot kopijo prvega.
// Ustvari po en objekt s vsakim od konstruktorjev in izpiši vse tri. Dodaj še Datum_v2 d4 = d1;
// Kakšna je razlika med zgornjo vrstico in uporabo kopirnega konstruktorja?
// Datumu d4 spremi leto, nato pa izpiši datume d1, d3 in d4? Kje se je spremenilo leto?

class Datum_v2
{
    public int Dan;
    public int Mesec;
    public int Leto;

    public Datum_v2()
    {
        var danes = DateTime.Now;
        Dan = danes.Day;
        Mesec = danes.Month;
        Leto = danes.Year;
    }

    public Datum_v2(int d, int m, int l)
    {
        Dan = d;
        Mesec = m;
        Leto = l;
    }

    public Datum_v2(Datum_v2 datum)
    {
        Dan = datum.Dan;
        Mesec = datum.Mesec;
        Leto = datum.Leto;
    }
}

class Naloga02
{
    static void Main()
    {
        var d1 = new Datum_v2();
        var d2 = new Datum_v2(15, 3, 2024);
        var d3 = new Datum_v2(d1);

        Console.WriteLine($"d1: {d1.Dan}.{d1.Mesec}.{d1.Leto}");
        Console.WriteLine($"d2: {d2.Dan}.{d2.Mesec}.{d2.Leto}");
        Console.WriteLine($"d3: {d3.Dan}.{d3.Mesec}.{d3.Leto}");

        Datum_v2 d4 = d1;
        d4.Leto = 2000;

        Console.WriteLine($"\nPo d4.Leto = 2000:");
        Console.WriteLine($"d1: {d1.Dan}.{d1.Mesec}.{d1.Leto}");
        Console.WriteLine($"d3: {d3.Dan}.{d3.Mesec}.{d3.Leto}");
        Console.WriteLine($"d4: {d4.Dan}.{d4.Mesec}.{d4.Leto}");
    }
}
