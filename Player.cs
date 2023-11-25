namespace _21_Game_Console;

public class Player
{
    private List<Card> _playerHand;

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
        originalDeck.RemoveAt(1);//po usunieciu indexu 0 index 2 staje sie index 1
    }
    
    public void PrintDeck()
    {
        var x = 0;
        foreach (var card in _playerHand)
        {
            Console.WriteLine($"{card.Suit}    {card.Face}    {card.Symbol}    {card.Value}");
            x++;
            Console.WriteLine(x);

        }
    }
    
}