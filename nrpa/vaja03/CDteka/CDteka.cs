namespace CDteka
{
    public class Skladba
    {
        private string naslov;
        private string avtorGlasbe;
        private string avtorBesedila;
        private int dolzinaVSekundah;

        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }

        public string AvtorGlasbe
        {
            get { return avtorGlasbe; }
            set { avtorGlasbe = value; }
        }

        public string AvtorBesedila
        {
            get { return avtorBesedila; }
            set { avtorBesedila = value; }
        }

        public int DolzinaVSekundah
        {
            get { return dolzinaVSekundah; }
            set
            {
                if (value >= 1 && value <= 5000)
                    dolzinaVSekundah = value;
            }
        }

        public Skladba()
        {
            naslov = "";
            avtorGlasbe = "";
            avtorBesedila = "";
            dolzinaVSekundah = 1;
        }

        public Skladba(string nas, string avtG, string avtB, int dolz)
        {
            naslov = nas;
            avtorGlasbe = avtG;
            avtorBesedila = avtB;

            if (dolz < 1)
                dolzinaVSekundah = 1;
            else if (dolz > 5000)
                dolzinaVSekundah = 5000;
            else
                dolzinaVSekundah = dolz;
        }
    }

    public class CD
    {
        private string naslov;
        private string band;
        private string zvrst;
        private int steviloSkladb;
        private Skladba[] skladbe;

        public string Naslov
        {
            get { return naslov; }
            set { naslov = value; }
        }

        public string Band
        {
            get { return band; }
            set { band = value; }
        }

        public string Zvrst
        {
            get { return zvrst; }
            set { zvrst = value; }
        }

        public int SteviloSkladb
        {
            get { return steviloSkladb; }
        }

        public Skladba[] Skladbe
        {
            get { return skladbe; }
        }

        public CD()
        {
            naslov = "";
            band = "";
            zvrst = "";
            steviloSkladb = 1;
            skladbe = new Skladba[steviloSkladb];
        }

        public CD(string nas, string b, string zv, int stSkladb)
        {
            naslov = nas;
            band = b;
            zvrst = zv;

            if (stSkladb < 1)
                steviloSkladb = 1;
            else if (stSkladb > 50)
                steviloSkladb = 50;
            else
                steviloSkladb = stSkladb;

            skladbe = new Skladba[steviloSkladb];
        }

        public int Dolzina()
        {
            int vsota = 0;
            for (int i = 0; i < steviloSkladb; i++)
            {
                if (skladbe[i] != null)
                    vsota += skladbe[i].DolzinaVSekundah;
            }
            return vsota;
        }
    }
}
