namespace ConsoleApp1;

public class Wypozyczenie
{
    private DateTime _momentWypozyczenia;
    private DateTime _terminZwrotu;
    private DateTime _faktycznyZwrot;
    private double _karaZaSpoznienie;
    private bool _czyZwrotWTerminie;

    protected Wypozyczenie(DateTime momentWypozyczenia, DateTime terminZwrotu, DateTime faktycznyZwrot)
    {
        _momentWypozyczenia = momentWypozyczenia;
        _terminZwrotu = terminZwrotu;
        _faktycznyZwrot  = faktycznyZwrot;
        if (terminZwrotu >= faktycznyZwrot)
        {
            _karaZaSpoznienie = 0;
            _czyZwrotWTerminie = true;
        }
        else
        {
            _karaZaSpoznienie = (faktycznyZwrot-terminZwrotu).TotalDays*20;
            _czyZwrotWTerminie = false;
        }
        



    }


}