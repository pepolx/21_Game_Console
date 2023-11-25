namespace _21_Game_Console;

public class Deck
{

    private int _decksPlaying;
    private int _cardsPerDeck = 52;
    private int RemainingCardsCount
    {
        get { return _deckOfCardsInGame.Count; }
    }

    private List<Card> _deckOfCardsInGame;

    public Deck(int decksPlaying)
    {
        _decksPlaying = decksPlaying;
        Initialize();
    }
    

    public List<Card> GetCurrentDeck()
    {
        return _deckOfCardsInGame;
    }

    private List<Card> Shuffle(List<Card> deck)
    {
        Random random = new Random();
        int cardsInGame =  _cardsPerDeck * _decksPlaying;
        while(cardsInGame > 1)
        {
            cardsInGame--;
            int k = random.Next(cardsInGame + 1);
            (deck[k], deck[cardsInGame]) = (deck[cardsInGame], deck[k]);
        }

        return deck;
    }

    private List<Card> GetDeck()
    {
        List<Card> deck = new List<Card>();
        int decks = _decksPlaying;
        while (decks > 0)
        {

            for (int i = 1; i < 14; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    deck.Add(new Card((Suit)j, (Face)i));
                }
            }

            decks--;

        }

        return deck;
    }

    private void Initialize()
    {
        _deckOfCardsInGame = GetDeck();
        Shuffle(_deckOfCardsInGame);

    }

    public void PrintDeck()
    {
        var x = 0;
        foreach (var card in _deckOfCardsInGame)
        {
            Console.WriteLine($"{card.Suit}    {card.Face}    {card.Symbol}    {card.Value}");
            x++;
            Console.WriteLine(x);

        }
    }

    public int GetNumberOfCardsLeft()
    {
        return RemainingCardsCount;
    }

    public bool IsEnoughCardsInDeck()
    {
        return RemainingCardsCount > 10;
    }

   
    
}