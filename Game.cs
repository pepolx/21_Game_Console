namespace _21_Game_Console;

public class Game
{
    private int _remainingCardsCount;
    
    private Dealer _dealer;
    private Player _player;
    private  Deck _deck;

    public Game(Dealer dealer, Player player, Deck deck)
    {
        _dealer = dealer;
        _player = player;
        _deck = deck;
    }
    
    public void GetCountOfRemainingCards(Deck deck)
    {
        _remainingCardsCount = deck.RemainingCardsCount;
        Console.WriteLine(_remainingCardsCount);
    }

    public bool IsEnoughCardsInDeck(Deck deck)
    {
        return deck.RemainingCardsCount >= 10;
    }
    
    public void GetOneCard()
    {
        Console.WriteLine("Jesli chcesz dobrac karte napisz 'g'");
        while (_player.ValueOfCards < 21 && Console.ReadLine() == "g")
        {
            _player.GetOneCard(_deck);
            _player.PrintHandWithValue();
            _player.GetValueOfCards();

        }
        
    }
    
    
}