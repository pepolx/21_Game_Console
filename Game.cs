namespace _21_Game_Console;

public class Game
{
    private int _remainingCardsCount;
    
    public void GetCountOfRemainingCards(Deck deck)
    {
        _remainingCardsCount = deck.RemainingCardsCount;
        Console.WriteLine(_remainingCardsCount);
    }

    public bool IsEnoughCardsInDeck(Deck deck)
    {
        return deck.RemainingCardsCount >= 10;
    }
    
    
}