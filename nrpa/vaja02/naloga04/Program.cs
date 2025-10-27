// Ustvari razred Datum_v4, ki se od prejšnje verzije razlikuje po tem, da implementira
// in uporablja lastnosti.
// Za vsak podatek ustvari javno lastnost z get metodo brez navedbe dosegljivosti in privatno
// set metodo. V vseh metodah in konstruktorjih uporabljaj lastnosti namesto direktnega dostopa.

class Datum_v4
{
    private int dan;
    private int mesec;
    private int leto;

    public int Dan
    {
        get { return dan; }
        private set { dan = value; }
    }

    public int Mesec
    {
        get { return mesec; }
        private set { mesec = value; }
    }

    public int Leto
    {
        get { return leto; }
        private set { leto = value; }
    }

    public Datum_v4()
    {
        var danes = DateTime.Now;
        Dan = danes.Day;
        Mesec = danes.Month;
        Leto = danes.Year;
    }

    public Datum_v4(int d, int m, int l)
    {
        if (JeVeljavenDatum(d, m, l))
        {
            Dan = d;
            Mesec = m;
            Leto = l;
        }
        else
        {
            var danes = DateTime.Now;
            Dan = danes.Day;
            Mesec = danes.Month;
            Leto = danes.Year;
        }
    }

    public Datum_v4(Datum_v4 drug)
    {
        Dan = drug.Dan;
        Mesec = drug.Mesec;
        Leto = drug.Leto;
    }

    public static bool JeVeljavenDatum(int d, int m, int l)
    {
        if (l < 1 || l > 9999) return false;
        if (m < 1 || m > 12) return false;

        int[] dnevi = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if ((l % 4 == 0 && l % 100 != 0) || (l % 400 == 0))
            dnevi[2] = 29;

        if (d < 1 || d > dnevi[m]) return false;
        return true;
    }

    public void NastaviDatum(int d, int m, int l)
    {
        if (JeVeljavenDatum(d, m, l))
        {
            Dan = d;
            Mesec = m;
            Leto = l;
        }
    }

    public void IzpisiDatum()
    {
        Console.WriteLine($"{Dan}.{Mesec}.{Leto}");
    }

    public static void IzpisiDatum(Datum_v4 datum)
    {
        datum.IzpisiDatum();
    }
}

class Naloga04
{
    static void Main()
    {
        var d1 = new Datum_v4();
        var d2 = new Datum_v4(25, 12, 2024);

        Console.WriteLine($"d1: Dan={d1.Dan}, Mesec={d1.Mesec}, Leto={d1.Leto}");
        d2.IzpisiDatum();

        d2.NastaviDatum(1, 1, 2025);
        d2.IzpisiDatum();
    }
}
