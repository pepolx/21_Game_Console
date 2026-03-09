namespace _21_Game_Console;

public class Player
{
    private readonly List<Card> _playerHand;
    private int _playerBalance;
    public int ValueOfCards { get; private set; }

    public Player()
    {
        _playerHand = new List<Card>();
    }

    public void GetStartsCards(Deck deckOfCards)
    {
        List<Card> originalDeck = deckOfCards.GetCurrentDeck();
        _playerHand.Add(originalDeck[0]);
        _playerHand.Add(originalDeck[2]);
        originalDeck.RemoveAt(0);
        originalDeck.RemoveAt(1); // after removing index 0, index 2 becomes index 1
        GetValueOfCards();
    }

    public void RemoveCardsFromHand()
    {
        _playerHand.Clear();
    }

    public void GetOneCard(Deck deckOfCards)
    {
        List<Card> originalDeck = deckOfCards.GetCurrentDeck();
        _playerHand.Add(originalDeck[0]);
        originalDeck.RemoveAt(0);
        GetValueOfCards();
    }

    public void GetValueOfCards()
    {
        ValueOfCards = HandValueCalculator.CalculateValue(_playerHand);
    }

    public void PrintHandWithAllValue()
    {
        foreach (var card in _playerHand)
        {
            Console.WriteLine($"{card.Face}    {card.Symbol}    {card.Value}");
        }
    }

    public void PrintHand()
    {
        foreach (var card in _playerHand)
        {
            Console.WriteLine($"{card.Face}    {card.Symbol}    {card.Value}");
        }
    }

    public List<Card> Hand()
    {
        return _playerHand;
    }

    public void PrintHandWithValue()
    {
        foreach (var card in _playerHand)
        {
            Console.WriteLine($"Gracz: {card.Face}    {card.Symbol}    {card.Value}");
        }

        Console.WriteLine($"Wartość ręki gracza: {ValueOfCards}");
    }
}
