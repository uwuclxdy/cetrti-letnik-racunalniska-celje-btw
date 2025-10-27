// Naloga 3 - Liki.cs (datoteka za dodati v projekt)
// Brez namespace-a
// Vsebuje razrede: Krog, Trikotnik, Kvadrat, Pravokotnik

public class Krog
{
    private double r;
    public readonly double ploscina;
    public readonly double obseg;

    public Krog()
    {
        r = 1;
        ploscina = LikiFormule.PloscinaKroga(r);
        obseg = LikiFormule.ObsegKroga(r);
    }

    public Krog(double polmer)
    {
        r = polmer < 0 ? 0 : polmer;
        ploscina = LikiFormule.PloscinaKroga(r);
        obseg = LikiFormule.ObsegKroga(r);
    }

    public Krog(Krog drug)
    {
        r = drug.r;
        ploscina = drug.ploscina;
        obseg = drug.obseg;
    }
}

public class Trikotnik
{
    private double a, b, c;
    public readonly double ploscina;
    public readonly double obseg;

    public Trikotnik()
    {
        a = 3;
        b = 4;
        c = 5;
        ploscina = LikiFormule.PloscinaTrikotnika(a, b, c);
        obseg = LikiFormule.ObsegTrikotnika(a, b, c);
    }

    public Trikotnik(double stranicaA, double stranicaB, double stranicaC)
    {
        a = stranicaA < 0 ? 0 : stranicaA;
        b = stranicaB < 0 ? 0 : stranicaB;
        c = stranicaC < 0 ? 0 : stranicaC;
        ploscina = LikiFormule.PloscinaTrikotnika(a, b, c);
        obseg = LikiFormule.ObsegTrikotnika(a, b, c);
    }

    public Trikotnik(Trikotnik drug)
    {
        a = drug.a;
        b = drug.b;
        c = drug.c;
        ploscina = drug.ploscina;
        obseg = drug.obseg;
    }
}

public class Kvadrat
{
    private double a;

    public double Ploscina
    {
        get { return LikiFormule.PloscinaKvadrata(a); }
    }

    public double Obseg
    {
        get { return LikiFormule.ObsegKvadrata(a); }
    }

    public Kvadrat()
    {
        a = 1;
    }

    public Kvadrat(double stranica)
    {
        a = stranica < 0 ? 0 : stranica;
    }

    public Kvadrat(Kvadrat drug)
    {
        a = drug.a;
    }
}

public class Pravokotnik
{
    private double a, b;

    public double Ploscina
    {
        get { return LikiFormule.PloscinaPravokotnika(a, b); }
    }

    public double Obseg
    {
        get { return LikiFormule.ObsegPravokotnika(a, b); }
    }

    public Pravokotnik()
    {
        a = 2;
        b = 3;
    }

    public Pravokotnik(double stranicaA, double stranicaB)
    {
        a = stranicaA < 0 ? 0 : stranicaA;
        b = stranicaB < 0 ? 0 : stranicaB;
    }

    public Pravokotnik(Pravokotnik drug)
    {
        a = drug.a;
        b = drug.b;
    }
}
