public class Datum
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

    public Datum()
    {
        var danes = DateTime.Now;
        Dan = danes.Day;
        Mesec = danes.Month;
        Leto = danes.Year;
        StDatumov++;
    }

    public Datum(int d, int m, int l)
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
    }

    public Datum(Datum drug)
    {
        Dan = drug.Dan;
        Mesec = drug.Mesec;
        Leto = drug.Leto;
        StDatumov++;
    }

    ~Datum()
    {
        StDatumov--;
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

    public bool JeLetoPrestopno()
    {
        return (Leto % 4 == 0 && Leto % 100 != 0) || (Leto % 400 == 0);
    }

    private int DniVMesecu(int m, int l)
    {
        int[] dnevi = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        if (((l % 4 == 0 && l % 100 != 0) || (l % 400 == 0)) && m == 2)
            return 29;
        return dnevi[m];
    }

    public void PovecajDatum()
    {
        Dan++;
        if (Dan > DniVMesecu(Mesec, Leto))
        {
            Dan = 1;
            Mesec++;
            if (Mesec > 12)
            {
                Mesec = 1;
                Leto++;
            }
        }
    }

    public void PovecajDatum(int dni)
    {
        for (int i = 0; i < dni; i++)
            PovecajDatum();
    }

    public void PomanjsajDatum()
    {
        Dan--;
        if (Dan < 1)
        {
            Mesec--;
            if (Mesec < 1)
            {
                Mesec = 12;
                Leto--;
            }
            Dan = DniVMesecu(Mesec, Leto);
        }
    }

    public void PomanjsajDatum(int dni)
    {
        for (int i = 0; i < dni; i++)
            PomanjsajDatum();
    }

    public void DanVTednu()
    {
        int d = Dan;
        int m = Mesec;
        int l = Leto;

        if (m < 3)
        {
            m += 12;
            l--;
        }

        int k = l % 100;
        int j = l / 100;
        int h = (d + (13 * (m + 1)) / 5 + k + k / 4 + j / 4 - 2 * j) % 7;

        string[] dnevi = { "Sobota", "Nedelja", "Ponedeljek", "Torek", "Sreda", "Četrtek", "Petek" };
        Console.WriteLine($"{Dan}.{Mesec}.{Leto} je {dnevi[h]}");
    }

    public void Izpisi(string oblika = "d.m.llll")
    {
        string[] meseci = { "", "jan", "feb", "mar", "apr", "maj", "jun",
                           "jul", "avg", "sep", "okt", "nov", "dec" };

        switch (oblika)
        {
            case "d.m.llll":
                Console.WriteLine($"{Dan}.{Mesec}.{Leto}");
                break;
            case "d.mmm.llll":
                Console.WriteLine($"{Dan}.{meseci[Mesec]}.{Leto}");
                break;
            case "dd.mm.ll":
                Console.WriteLine($"{Dan:D2}.{Mesec:D2}.{Leto % 100:D2}");
                break;
            default:
                Console.WriteLine($"{Dan}.{Mesec}.{Leto}");
                break;
        }
    }

    public static void Izpisi(Datum datum, string oblika = "d.m.llll")
    {
        datum.Izpisi(oblika);
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
}
