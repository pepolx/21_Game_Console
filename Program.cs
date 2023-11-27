namespace _21_Game_Console;

public static class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new Deck(2);
        Game game = new Game();
        Player player = new Player();
        Dealer dealer = new Dealer();
        while (game.IsEnoughCardsInDeck(deck))
        {
            //deck.PrintDeck();
            player.GetStartsCards(deck);
            dealer.GetStartsCards(deck);
            player.GetOneCard(deck);
            dealer.PrintHandWithValue();
            player.PrintHandWithValue();
            Console.ReadLine(); 

        }
        
        
        
    }
}

