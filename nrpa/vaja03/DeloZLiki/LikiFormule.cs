public static class LikiFormule
{
    public const double PI = 3.14;

    public static double PloscinaKvadrata(double a)
    {
        return a * a;
    }

    public static double ObsegKvadrata(double a)
    {
        return 4 * a;
    }

    public static double PloscinaPravokotnika(double a, double b)
    {
        return a * b;
    }

    public static double ObsegPravokotnika(double a, double b)
    {
        return 2 * (a + b);
    }

    public static double PloscinaKroga(double r)
    {
        return r * r * PI;
    }

    public static double ObsegKroga(double r)
    {
        return 2 * r * PI;
    }

    public static double PloscinaTrikotnika(double a, double ha)
    {
        return (a * ha) / 2;
    }

    public static double PloscinaTrikotnika(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public static double ObsegTrikotnika(double a, double b, double c)
    {
        return a + b + c;
    }
}
