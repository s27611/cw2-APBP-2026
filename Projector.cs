namespace ConsoleApp1;

public class Projector : Sprzet
{
    private String _producent;
    private int _poziomJasnosci;

    public Projector(string nazwaSprzet, bool dostepny, string producent, int poziomJasnosci) : base(nazwaSprzet, dostepny)
    {
        _producent = producent;
        _poziomJasnosci = poziomJasnosci;
    }
}