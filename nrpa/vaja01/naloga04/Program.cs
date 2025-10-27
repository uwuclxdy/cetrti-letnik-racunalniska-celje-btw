//Ustvari razred Stevec, ki vsebuje podatek vrednost in ima tri konstruktorje: v privzetem naj se vrednost nastavi na 0,
//v pretvorbenem na vrednost, ki je podana, v kopirnem pa na vrednost obstoječega objekta.
//Dodaj še metode za povečevanje vrednosti za 1, za zmanjševanje vrednosti za 1 in za izpis trenutne vrednosti.
//V glavnem programu ustvari nekaj objektov razreda števec in demonstriraj uporabo.

class Stevec
{
    private int _vrednost;

    public Stevec()
    {
        _vrednost = 0;
    }

    public Stevec(int vrednost)
    {
        _vrednost = vrednost;
    }

    public Stevec(Stevec obstoječi)
    {
        _vrednost = obstoječi._vrednost;
    }

    public void Povecaj()
    {
        _vrednost++;
    }

    public void Zmanjsaj()
    {
        _vrednost--;
    }

    public void Izpis()
    {
        Console.WriteLine($"Trenutna vrednost: {_vrednost}");
    }
}

file class Program
{
    static void Main()
    {
        Stevec s1 = new Stevec();
        Stevec s2 = new Stevec(10);
        Stevec s3 = new Stevec(s2);

        s1.Izpis();
        s1.Povecaj();
        s1.Izpis();

        s2.Izpis();
        s2.Zmanjsaj();
        s2.Izpis();

        s3.Izpis();
    }
}
