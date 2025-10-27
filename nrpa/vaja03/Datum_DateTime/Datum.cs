public class Datum
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
