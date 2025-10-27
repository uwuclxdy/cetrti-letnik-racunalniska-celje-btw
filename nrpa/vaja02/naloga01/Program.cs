// V novem konzolskem projektu Ustvari razred Datum_v1.
// Dan, mesec in leto naj bodo javni podatki, shranjeni kot podatki tipa integer.
// V glavnem programu ustvari nov primerek datuma in ga izpiši. Kakšne so njegove vrednosti?
//

class Datum_v1
{
    public int Dan;
    public int Mesec;
    public int Leto;
}

class Naloga01
{
    static void Main()
    {
        var d = new Datum_v1();
        Console.WriteLine($"Dan: {d.Dan}, Mesec: {d.Mesec}, Leto: {d.Leto}");
    }
}
