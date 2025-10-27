// 6.	Ustvari razred Oseba. Podatki so naslednji:
// ime: niz
// priimek: niz
// datumRojstva: razred Datum iz prejšnje naloge
//
//     Napiši privzeti konstruktor, ki vse tri vrednosti nastavi na null, konstruktor, ki mu podaš podatke o osebi in kopirni konstruktor. Napiši metodo, ki izpiše podatke o osebi. Pri izpisu datuma uporabi metodo iz razreda Datum.
//
//     V glavnem programu deklariraj tri objekte razreda Oseba. Uporabi različne konstruktorje. Izpiši podatke vseh oseb.


class Datum
{
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }

    public Datum()
    {
        Day = 1;
        Month = 1;
        Year = 2000;
    }

    public Datum(int day, int month, int year)
    {
        Day = day;
        Month = month;
        Year = year;
    }

    // Return a copy of this Datum
    public Datum Clone()
    {
        return new Datum(Day, Month, Year);
    }

    public void Validate()
    {
        bool valid = Month >= 1 && Month <= 12;
        if (valid)
        {
            int[] md = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0)) md[1] = 29;

            valid = Day >= 1 && Day <= md[Month - 1];
        }

        if (!valid)
        {
            Console.WriteLine("Datum ni veljaven. Nastavljen na 0.0.0");
            Day = Month = Year = 0;
        }
    }

    public void Print()
    {
        Console.WriteLine($"{Day}.{Month}.{Year}");
    }
}

class Oseba
{
    public string? Ime { get; set; }
    public string? Priimek { get; set; }
    public Datum? DatumRojstva { get; set; }

    // Default constructor: all null
    public Oseba()
    {
        this.Ime = null;
        this.Priimek = null;
        this.DatumRojstva = null;
    }

    // Parameter constructor (accepts nullable Datum)
    public Oseba(string? ime, string? priimek, Datum? datumRojstva)
    {
        Ime = ime;
        Priimek = priimek;
        DatumRojstva = datumRojstva?.Clone();
    }

    // Copy constructor (accepts null other)
    public Oseba(Oseba? other)
    {
        if (other is null)
        {
            Ime = null;
            Priimek = null;
            DatumRojstva = null;
        }
        else
        {
            Ime = other.Ime;
            Priimek = other.Priimek;
            DatumRojstva = other.DatumRojstva?.Clone();
        }
    }

    public void Print()
    {
        Console.WriteLine("Oseba:");
        Console.WriteLine($"Ime: {Ime ?? "(null)"}");
        Console.WriteLine($"Priimek: {Priimek ?? "(null)"}");
        Console.Write("Datum rojstva: ");
        if (DatumRojstva is null)
            Console.WriteLine("null");
        else
            DatumRojstva.Print();
    }
}

file class Program
{
    static void Main()
    {
        var o1 = new Oseba();

        var d2 = new Datum(5, 6, 1990);
        d2.Validate();
        var o2 = new Oseba("Ana", "Kovač", d2);

        var o3 = new Oseba(o2);

        o1.Print();
        o2.Print();
        o3.Print();
    }
}
