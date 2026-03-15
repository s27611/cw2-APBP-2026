namespace ConsoleApp1;

public abstract class Sprzet
{
    private int licznikId = 0;
    private int idSprzet;
    private string nazwaSprzet;
    private bool dostepny;


    protected Sprzet(string nazwaSprzet, bool dostepny)
    {
        this.nazwaSprzet = nazwaSprzet;
        this.dostepny = dostepny;
        idSprzet=licznikId++;
    }
}