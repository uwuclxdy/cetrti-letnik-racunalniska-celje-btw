// 3.   Ustvari razred Semafor. Z ustreznimi metodami naj omogoča prižiganje luči in izpis trenutno prižgane luči.
//     Dodaj še metodo, ki vrača true, če trenutno lahko prečkamo cesto in false, če je ne smemo.
//     V glavnem programu ustvari nekaj objektov razreda semafor in demonstriraj uporabo.

namespace naloga03;

class Semafor
{
    private bool rdeca;
    private bool rumena;
    private bool zelena;

    public void Prizgi(bool Rdeca, bool Rumena, bool Zelena)
    {
        rdeca = Rdeca;
        rumena = Rumena;
        zelena = Zelena;
    }

    public void Izpis()
    {
        Console.WriteLine("Rdeca: " + rdeca);
        Console.WriteLine("Rumena: " + rumena);
        Console.WriteLine("Zelena: " + zelena);
    }

    public void LahkoPreckamo()
    {
        if (zelena) Console.WriteLine("Lahko preckamo");
        else Console.WriteLine("Ne smemo preckati");
    }
}

class Naloga03
{
    public static void Main()
    {
        Semafor s = new Semafor();
        s.Prizgi(true,false,false);
        s.Izpis();
        s.LahkoPreckamo();
        s.Prizgi(false,false,true);
        s.LahkoPreckamo();
    }
}
