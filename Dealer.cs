namespace _21_Game_Console;

public class Dealer
{
    private List<Card> _dealerHand;
    public int ValueOfCards { get; private set; }

    public Dealer()
    {
        _dealerHand = new List<Card>();
    }
    
    public void GetStartsCards(Deck deckOfCards)
    {
        List<Card> originalDeck = deckOfCards.GetCurrentDeck();
        _dealerHand.Add(originalDeck[0]);
        _dealerHand.Add(originalDeck[1]);
        originalDeck.RemoveRange(0,2);
        GetValueOfCards();
    }
    
    public void GetOneCard(Deck deckOfCards)
    {
        List<Card> originalDeck = deckOfCards.GetCurrentDeck();
        _dealerHand.Add(originalDeck[0]);
        originalDeck.RemoveAt(0);
        GetValueOfCards();
    }
    
    public void RemoveCardsFromHand()
    {
        _dealerHand.Clear();
    }
    
    private void GetValueOfCards()
    {
        ValueOfCards = 0;
        foreach (var card in _dealerHand)
        {
            ValueOfCards += card.Value;
        }
        
    }
    
    public void PrintHandWithAllValue()
    {
        var x = 0;
        foreach (var card in _dealerHand)
        {
            Console.WriteLine($"{card.Suit}    {card.Face}    {card.Symbol}    {card.Value}");
            x++;
            Console.WriteLine(x);

        }
    }
    public void PrintHand()
    {
        foreach (var card in _dealerHand)
        {
            Console.WriteLine($"{card.Face}    {card.Symbol}    {card.Value}");
        }
    }
    
    public void PrintHandWithValue()
    {
        foreach (var card in _dealerHand)
        {
            Console.WriteLine($"{card.Face}    {card.Symbol}    {card.Value}");
        }

        Console.WriteLine(ValueOfCards);
    }
}