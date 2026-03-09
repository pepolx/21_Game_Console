namespace _21_Game_Console;

public class ConsoleInterface
{
    private readonly Dealer _dealer;
    private readonly Player _player;
    private readonly Deck _deck;

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
        else if (_dealer.ValueOfCards == _player.ValueOfCards)
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
        while (Console.ReadLine() == "g" && _player.ValueOfCards < 21)
        {
            _player.GetOneCard(_deck);
            _player.PrintHandWithValue();
        }
    }

    public void PrintHandWithValue(List<Card> hand, string owner)
    {
        foreach (var card in hand)
        {
            Console.WriteLine($"{owner}: {card.Face}    {card.Symbol}    {card.Value}");
        }

        var handValue = HandValueCalculator.CalculateValue(hand);
        Console.WriteLine($"Wartość ręki ({owner}): {handValue}");
    }
}
