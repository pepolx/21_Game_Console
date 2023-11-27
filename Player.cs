namespace _21_Game_Console;

public class Player
{
    private List<Card> _playerHand;
    private int _playerBalance;
    private int _playerValueOfCards;
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

    private void GetValueOfCards()
    {
        foreach (var card in _playerHand)
        {
            _playerValueOfCards += card.Value;
        }
        
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