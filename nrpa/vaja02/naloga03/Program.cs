// Razredu Datum_v2 lahko nastavimo povsem neveljaven datum. V novem projektu ustvari Datum_v3,
// ki bo take napake preprečeval.
// V ta namen napiši javno statično metodo JeVeljavenDatum, ki prejme tri cela števila za dan,
// mesec in leto ter vrača vrednost bool. V kontruktorju s pomočjo te metode preveri, ali je
// želeni datum smiseln in če ni, namesto želenega nastavi datum na današnjega.
// Podatki razreda naj bodo privatni, tako da jih ne bo več mogoče direktno spreminjati.
// Za spreminjanje ustvari javno objektno metodo NastaviDatum.
// Dodaj še objektno in statično verzijo javne metode IzpisiDatum.

class Datum_v3
{
    private int dan;
    private int mesec;
    private int leto;

    public Datum_v3()
    {
        var danes = DateTime.Now;
        dan = danes.Day;
        mesec = danes.Month;
        leto = danes.Year;
    }

    public Datum_v3(int d, int m, int l)
    {
        if (JeVeljavenDatum(d, m, l))
        {
            dan = d;
            mesec = m;
            leto = l;
        }
        else
        {
            var danes = DateTime.Now;
            dan = danes.Day;
            mesec = danes.Month;
            leto = danes.Year;
        }
    }

    public Datum_v3(Datum_v3 datum)
    {
        dan = datum.dan;
        mesec = datum.mesec;
        leto = datum.leto;
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
            dan = d;
            mesec = m;
            leto = l;
        }
    }

    public void IzpisiDatum()
    {
        Console.WriteLine($"{dan}.{mesec}.{leto}");
    }

    public static void IzpisiDatum(Datum_v3 datum)
    {
        datum.IzpisiDatum();
    }
}

class Naloga03
{
    static void Main()
    {
        Console.Write("Dan: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Mesec: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Leto: ");
        int l = int.Parse(Console.ReadLine());

        var datum = new Datum_v3(d, m, l);
        Datum_v3.IzpisiDatum(datum);

        Console.Write("\nNov dan: ");
        d = int.Parse(Console.ReadLine());
        Console.Write("Nov mesec: ");
        m = int.Parse(Console.ReadLine());
        Console.Write("Novo leto: ");
        l = int.Parse(Console.ReadLine());

        datum.NastaviDatum(d, m, l);
        datum.IzpisiDatum();
    }
}
