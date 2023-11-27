namespace _21_Game_Console;

public class Player
{
    private List<Card> _playerHand;
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
        originalDeck.RemoveAt(1);//after removing index 0, index 2 becomes index 1
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

    private void GetValueOfCards()
    {
        ValueOfCards = 0;
        foreach (var card in _playerHand)
        {
            ValueOfCards += card.Value;
        }
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
    
    public void PrintHandWithValue()
    {
        foreach (var card in _playerHand)
        {
            Console.WriteLine($"{card.Face}    {card.Symbol}    {card.Value}");
        }
        Console.WriteLine(ValueOfCards);
    }
    
}