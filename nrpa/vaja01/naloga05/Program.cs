//Ustvari razred Datum. Razred naj vsebuje podatke o dnevu, mesecu in letu. Vsi so cela števila.
//Napiši privzeti konstruktor ki nastavi datum na 1.1.2000, in pretvorbeni konstruktor, ki ga nastavi na poljuben datum.
//Definiraj ustrezne lastnosti in jih uporabi v glavnem programu. Napiši metodo, ki preveri,
//ali je nastavljeni datum sploh veljaven. Če ni, obvesti uporabnika in ga nastavi na 0.0.0.
//Napiši še metodo, ki izpiše datum.

using System;

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

    public void Validate()
    {
        bool valid = Month >= 1 && Month <= 12;
        if (valid)
        {
            int[] md = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0))
            {
                md[1] = 29;
            }
            valid = Day >= 1 && Day <= md[Month - 1];
        }
        if (!valid)
        {
            Console.WriteLine("Datum ni veljaven. Nastavljen na 0.0.0");
            Day = 0;
            Month = 0;
            Year = 0;
        }
    }

    public void Print()
    {
        Console.WriteLine($"{Day}.{Month}.{Year}");
    }
}

class Program
{
    static void Main()
    {
        new Datum().Print();

        var d2 = new Datum(29, 2, 2024);
        d2.Validate();
        d2.Print();

        var d3 = new Datum();
        d3.Day = 15;
        d3.Month = 10;
        d3.Year = 2023;
        d3.Validate();
        d3.Print();

        var d4 = new Datum(32, 13, 2023);
        d4.Validate();
        d4.Print();
    }
}
