// Ustvari nov projekt in vanj kopiraj kodo glavnega programa iz prejšnjega. Nato ustvari nov razred Datum.
// Nov razred Datum naj se od starega razlikuje po tem, da ima namesto podatka dan, mesec in leto
// en sam podatek razreda DateTime.
// Prilagodi konstruktorje novi predstavitvi datuma.
// Vse lastnosti naj bodo navzven povsem enake (predstavljajo torej dan, mesec, leto in število datumov),
// spremeni pa get in set metode (set metode bodo morale ustvariti nov DateTime, saj obstoječega ni mogoče spreminjati)
// Spremeni metode, ki zahtevajo spremembe zaradi nove predstavitve podatkov.

class Datum
{
    private DateTime datum;
    private static int stDatumov = 0;

    public static int StDatumov
    {
        get { return stDatumov; }
        private set { stDatumov = value; }
    }

    public int Dan
    {
        get { return datum.Day; }
        private set { datum = new DateTime(datum.Year, datum.Month, value); }
    }

    public int Mesec
    {
        get { return datum.Month; }
        private set { datum = new DateTime(datum.Year, value, datum.Day); }
    }

    public int Leto
    {
        get { return datum.Year; }
        private set { datum = new DateTime(value, datum.Month, datum.Day); }
    }

    public Datum()
    {
        datum = DateTime.Now.Date;
        StDatumov++;
    }

    public Datum(int d, int m, int l)
    {
        if (JeVeljavenDatum(d, m, l))
            datum = new DateTime(l, m, d);
        else
            datum = DateTime.Now.Date;
        StDatumov++;
    }

    public Datum(Datum drug)
    {
        datum = drug.datum;
        StDatumov++;
    }

    ~Datum()
    {
        StDatumov--;
    }

    public static bool JeVeljavenDatum(int d, int m, int l)
    {
        try
        {
            DateTime test = new DateTime(l, m, d);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public bool JeLetoPrestopno()
    {
        return DateTime.IsLeapYear(datum.Year);
    }

    public void PovecajDatum()
    {
        datum = datum.AddDays(1);
    }

    public void PovecajDatum(int dni)
    {
        datum = datum.AddDays(dni);
    }

    public void PomanjsajDatum()
    {
        datum = datum.AddDays(-1);
    }

    public void PomanjsajDatum(int dni)
    {
        datum = datum.AddDays(-dni);
    }

    public void DanVTednu()
    {
        string[] dnevi = { "Nedelja", "Ponedeljek", "Torek", "Sreda", "Četrtek", "Petek", "Sobota" };
        DayOfWeek dow = datum.DayOfWeek;
        Console.WriteLine($"{datum.Day}.{datum.Month}.{datum.Year} je {dnevi[(int)dow]}");
    }

    public void Izpisi(string oblika = "d.m.llll")
    {
        string[] meseci =
        [
            "", "jan", "feb", "mar", "apr", "maj", "jun",
            "jul", "avg", "sep", "okt", "nov", "dec"
        ];

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

    public static void Izpisi(Datum dat, string oblika = "d.m.llll")
    {
        dat.Izpisi(oblika);
    }

    public void NastaviDatum(int d, int m, int l)
    {
        if (JeVeljavenDatum(d, m, l))
            datum = new DateTime(l, m, d);
    }
}

class Naloga07
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
