namespace _21_Game_Console;

public static class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new Deck(2);
        Game game = new Game();
        Player player = new Player();
        Dealer dealer = new Dealer();
        ConsoleInterface UI = new ConsoleInterface(dealer, player, deck);
        while (game.IsEnoughCardsInDeck(deck))
        {
            //deck.PrintDeck();
            player.GetStartsCards(deck);
            dealer.GetStartsCards(deck);

            dealer.PrintHandWithValue();
            player.PrintHandWithValue();
           UI.GetOneCard();

            if (dealer.ValueOfCards < 17)
            {
                dealer.GetOneCard(deck);
            }
            dealer.PrintHandWithValue();
            
            UI.Result();
            player.RemoveCardsFromHand();
            dealer.RemoveCardsFromHand();
            
            Console.ReadLine(); 

        }
        
        
        
    }
}

