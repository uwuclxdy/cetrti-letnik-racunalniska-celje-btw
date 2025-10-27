// Ustvari razred Datum_v5, ki bo prejšnji verziji dodal še privaten statičen podatek
// stDatumov in javno statično lastnost StDatumov.
// Inicializiraj stDatumov na 0.
// Popravi vse konstruktorje tako, da bodo ob ustvarjanju novega datuma povečali StDatumov za ena
// in izpisali, koliko je trenutno datumov.
// Napiši destruktor, ki bo ob uničenju objekta pomanjšal StDatumov in izpisal, koliko je trenutno datumov.

class Datum_v5
{
    private int dan;
    private int mesec;
    private int leto;
    private static int stDatumov = 0;

    public static int StDatumov
    {
        get { return stDatumov; }
        private set { stDatumov = value; }
    }

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

    public Datum_v5()
    {
        var danes = DateTime.Now;
        Dan = danes.Day;
        Mesec = danes.Month;
        Leto = danes.Year;
        StDatumov++;
        Console.WriteLine($"Konstruktor: StDatumov = {StDatumov}");
    }

    public Datum_v5(int d, int m, int l)
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
        StDatumov++;
        Console.WriteLine($"Konstruktor: StDatumov = {StDatumov}");
    }

    public Datum_v5(Datum_v5 drug)
    {
        Dan = drug.Dan;
        Mesec = drug.Mesec;
        Leto = drug.Leto;
        StDatumov++;
        Console.WriteLine($"Konstruktor: StDatumov = {StDatumov}");
    }

    ~Datum_v5()
    {
        StDatumov--;
        Console.WriteLine($"Destruktor: StDatumov = {StDatumov}");
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

    public static void IzpisiDatum(Datum_v5 datum)
    {
        datum.IzpisiDatum();
    }
}

class Naloga05
{
    static void Main()
    {
        var d1 = new Datum_v5();
        var d2 = new Datum_v5(15, 3, 2024);
        var d3 = new Datum_v5(d1);

        Console.WriteLine($"\nŠtevilo datumov: {Datum_v5.StDatumov}");

        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
