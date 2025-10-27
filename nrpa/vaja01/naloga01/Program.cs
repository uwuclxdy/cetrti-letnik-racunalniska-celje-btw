// 1.   Ustvari razred Kvadrat1 z javnim podatkom stranica ter javnima metodama IzracunajPloscino in IzracunajObseg.
//
//     V glavnem programu ustvari dva objekta razreda Kvadrat1 in jima nastavi dve različni stranici ter izpiši ploščino in obseg obeh kvadratov.
//     Kaj se zgodi, če za dolžino stranico nastaviš negativno število? 
//     Dodaj nov razred Kvadrat2 tako, da bo podatek stranica privaten in da bo imel javno metodo NastaviStranico, ki bo preverjala, ali je želena dolžina stranice negativna in jo bo v tem primeru nastavila na 0. Obe metodi za izračun naj ostaneta nespremenjeni.
//     V glavnem programu ustvari dva objekta razreda Kvadrat2 in jima nastavi dve različni stranici ter izpiši ploščino in obseg obeh kvadratov.
//     Kaj se zgodi, če za dolžino stranico nastaviš negativno število?

class Kvadrat1
{
    public float stranica { get; set; }

    public float IzracunajPloscino()
    {
        return stranica * stranica;
    }

    public float IzracunajObseg()
    {
        return 4 * stranica;
    }
}

class Kvadrat2
{
    private float stranica { get; set; }

    public void NastaviStranico(float stranica)
    {
        if (0 > stranica) stranica = 0;
        this.stranica = stranica;
    }
    
    public float IzracunajPloscino()
    {
        return stranica * stranica;
    }

    public float IzracunajObseg()
    {
        return 4 * stranica;
    }
}

class Naloga01
{
    public static void Main()
    {
        Kvadrat1 prvi = new();
        Kvadrat1 drugi = new();

        prvi.stranica = -6.9f;
        drugi.stranica = 6.7f;
        
        Console.WriteLine(prvi.IzracunajObseg());
        Console.WriteLine(prvi.IzracunajPloscino());
        
        Console.WriteLine(drugi.IzracunajObseg());
        Console.WriteLine(drugi.IzracunajPloscino());
        
        Kvadrat2 tretji = new();
        Kvadrat2 cetrti = new();

        tretji.NastaviStranico(-6.9f);
        cetrti.NastaviStranico(6.7f);
        
        Console.WriteLine(tretji.IzracunajObseg());
        Console.WriteLine(tretji.IzracunajPloscino());
        
        Console.WriteLine(cetrti.IzracunajObseg());
        Console.WriteLine(cetrti.IzracunajPloscino());
    }
}
