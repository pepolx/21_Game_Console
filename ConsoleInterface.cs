namespace _21_Game_Console;

public class ConsoleInterface
{
    private Dealer _dealer;
    private Player _player;
    private  Deck _deck;

    public ConsoleInterface(Dealer dealer, Player player, Deck deck)
    {
        _dealer = dealer;
        _player = player;
        _deck = deck;
    }
    public void Result()
    {
        if (_dealer.ValueOfCards > _player.ValueOfCards && _dealer.ValueOfCards < 22 
            || _player.ValueOfCards > 21)
        {
            Console.WriteLine("Przegrywasz");
        }
        else if(_dealer.ValueOfCards == _player.ValueOfCards)
        {
            Console.WriteLine("Remis");
        }
        else
        {
            Console.WriteLine("Wygrywasz");
        }
    }

    public void GetOneCard()
    {
        Console.WriteLine("Jesli chcesz dobrac karte napisz 'g'");
        while (Console.ReadLine() == "g")
        {
            _player.GetOneCard(_deck);
            _player.PrintHandWithValue();
        }
        
    }
}