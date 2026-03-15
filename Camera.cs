namespace ConsoleApp1;

public class Camera : Sprzet
{
    private string _rozdzielczość;
    private bool _czyWKolorze;

    public Camera(string nazwaSprzet, bool dostepny, bool czyWKolorze, String rozdzielczość) : base(nazwaSprzet, dostepny)
    {
        _rozdzielczość = rozdzielczość;
        _czyWKolorze = czyWKolorze;
    }
}