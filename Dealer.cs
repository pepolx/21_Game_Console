namespace _21_Game_Console;

public class Dealer
{
    private List<Card> _dealerHand;

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
    }
    
    public void PrintDeck()
    {
        var x = 0;
        foreach (var card in _dealerHand)
        {
            Console.WriteLine($"{card.Suit}    {card.Face}    {card.Symbol}    {card.Value}");
            x++;
            Console.WriteLine(x);

        }
    }
}