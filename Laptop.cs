namespace ConsoleApp1;

public class Laptop : Sprzet
{
    private String _systemOperacyjny;
    private double _przekatnaEkranu;

    public Laptop(string nazwaSprzet, bool dostepny, string systemOperacyjny, double przekatnaEkranu) : base(nazwaSprzet, dostepny)
    {
        _systemOperacyjny = systemOperacyjny;
        _przekatnaEkranu = przekatnaEkranu;
    }
}