// 2.   Ustvari razred Denarnica, ki ima podatek o stanju. Napiši metodi za dvig in polog denarja ter metodo za izpis stanja v denarnici. Napiši privzeti konstruktor, ki nastavi stanje denarnice na 0. Napiši kopirni konstruktor, ki prekopira stanje druge denarnice. Napiši še pretvorbeni konstruktor, ki nastavi začetno stanje v denarnici na želeno.
//
// I.   Deklaracija razreda.
// 1.   Določimo ime razreda. (class Denarnica)
// 2.   Z določilom private dodajmo podatke, ki so dostopni samo metodam razreda. Podatek je v našem primeru stanje na računu, ki pove, koliko denarja imamo na računu. Stanje je lahko na primer 12,54. Torej moramo za podatek uporabiti tip realno število. Ime mu bomo dali stanje. (double stanje)
// 3.   Potrebujemo še metode, ki bodo skrbele za pravilno delo z denarnico. Metode bodo javne (public), torej dostopne tudi izven razreda.
// 4.   Dodajmo metodo za dvig, ki bo pomenila, da iz denarnice odstranimo želeno vsoto denarja in z njo, recimo, plačamo kosilo v gostilni. Metoda se bo imenovala Dvig, in bo imela en argument in sicer vsoto denarja, ki ga bomo dvignili. Argument bo tipa realno število (double), istega tipa kot je podatek o stanju. Metoda bo vrnila vrednost true ali false, odvisno od uspešnosti dviga denarja. Dvig je uspešen, če je vsota, ki jo želimo dvigniti manjša od stanja v denarnici. (Pri dvigu denarja, se bo stanje v denarnici zmanjšalo za velikost dviga. Če želimo dvigniti preveč, se stanje ne spremeni, metoda pa vrne false).
// 5.   Dodajmo metodo Polog, ki bo kot argument sprejela realno število. Metoda bo ta argument prištela stanju. Vrnila ne bo nič. Če pride do poskusa pologa negativnega števila, naj metoda stanja ne spremeni.
// 6.   Dodajmo še metodo VrniStanje, ki vrne podatek tipa double (stanje). Ne sprejme nobenega argumenta.
// 7.   Dodajmo tri konstruktorje. Vsi naj bodo javni,da bomo lahko v glavnem programu ustvarili primerke denarnic. Konstruktorji ne vračajo nikakršnega tipa (niti void).
//     Prvi konstruktor naj bo privzeti konstruktor (brez argumentov). Ta konstruktor nastavi stanje na 0.
//     Drugi konstruktor bo kopirni konstruktor. Ta sprejme kot argument objekt razreda Denarnica. Podatek stanja iz tega argumenta se prenese v podatek stanje.
//     Tretji konstruktor naj bo pretvorbeni: za argument naj ima realno število. Ta konstruktor nastavi začetno stanje na vrednost tega argumenta. Če je argument negativno število, naj bo stanje b denarnici 0.
//
//


class Denarnica
{
    private float stanje { get; set; }
    public float Stanje { get; set; }

    public void Polog(float znesek)
    {
        stanje =+ znesek;
        Console.WriteLine("Polog v znesku: " + znesek);
    }

    public void Dvig(float znesek)
    {
        stanje =- znesek;
        Console.WriteLine("Dvig v znesku: " + znesek);
    }

    public void Izpis()
    {
        Console.WriteLine("Stanje: " + stanje);
    }

    public Denarnica()
    {
        stanje = 0;
    }

    public Denarnica(Denarnica denarnica)
    {
        stanje = denarnica.stanje;
    }

    public Denarnica(float stanje)
    {
        this.stanje = stanje;
    }

    ~Denarnica()
    {
        Console.WriteLine("Program se bo zaprl :P");
    }
}

// II.  Uporaba razreda
// 1.   V glavnem programu uporabimo razred, ki smo ga zgoraj opisali.
// 2.   Ustvarimo tri objekte. Imena naj bodo sledeča: mirko, marko in darko.
// 3.   Objekt mirko ustvarimo s privzetim konstruktorjem.
// 4.   Objekt marko usvarimo s kopirnim konstruktorjem. Podatke prepišimo iz objekta mirko.
// 5.   Tretji objekt darko ustvarimo s pretvorbenim konstruktorjem. Začetno stanje nastavimo na 100.
// 6.   Pri vsakem objektu dvakrat uporabimo metode, ki smo jih implementirali.
// 7.   Pri metodah Dvig in Polog poskusimo uporabiti ”prepovedane vrednosti”. Kaj se zgodi?
// 8.   Poskusimo dostopati direktno do lastnosti stanje (recimo darko.stanje). Kaj se zgodi? nemoreš ker je private
// 9.   Spremenimo način dostopa do podatka stanje na public, internal, protected in protected internal. V katerih primerih je dostopen iz drugega razreda (razreda, kjer je glavni program)? public, internal, protected internal
// 10.  Povrnimo podatek stanje na private in dodajmo lastnost Stanje. Preizkusimo zgoraj naštete načine dostopa do nje. Na koncu naj bo lastnost javna.
// 11.  Kdaj se objekti uničijo? Kako jih uničimo? ko zapremo program ali pa ko noben del programa ne potrebuje več in ga garbage collector pobriše
// 12.  V konstruktor in destruktor dodajmo vrstico, ki bo izpisala, da se je izvedel določen konstruktor (destruktor). Preverimo delovanje.

class Naloga02
{
    public static void Main()
    {
        Denarnica mirko = new();
        Denarnica marko = new(mirko);
        Denarnica darko = new(100);

        mirko.Polog(-100);
        marko.Polog(100);
        darko.Polog(100);

        mirko.Dvig(67);
        marko.Dvig(67);
        mirko.Dvig(-67);

        mirko.Izpis();
        marko.Izpis();
        darko.Izpis();
    }
}
