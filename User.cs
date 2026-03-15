namespace ConsoleApp1;

public abstract class User
{
    private int _licznikId = 0;
    private int _idUser;
    private String _name;
    private Sprzet _nazwisko;
    private String _typ;


    protected User(string name, Sprzet nazwisko, string typ)
    {
        _name = name;
        _nazwisko = nazwisko;
        _typ = typ;
        _idUser = _licznikId++;
    }
}