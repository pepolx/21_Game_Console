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
            if (player.ValueOfCards <= 16)
            {
                player.GetOneCard(deck);
            }
            dealer.PrintHandWithValue();
            player.PrintHandWithValue();
            if (dealer.ValueOfCards > player.ValueOfCards)
            {
                Console.WriteLine("Przegrywasz");
            }
            else
            {
                Console.WriteLine("Wygywasz");
            }
            player.RemoveCardsFromHand();
            dealer.RemoveCardsFromHand();
            
            Console.ReadLine(); 

        }
        
        
        
    }
}

