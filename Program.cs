namespace _21_Game_Console;

public static class Program
{
    private static void Main(string[] args)
    {
        var deck = new Deck(2);
        var player = new Player();
        var dealer = new Dealer();
        var ui = new ConsoleInterface(dealer, player, deck);
        var game = new Game(dealer, player, deck);
        while (game.IsEnoughCardsInDeck(deck))
        {
            //deck.PrintDeck();      
            player.GetStartsCards(deck);
            dealer.GetStartsCards(deck);

            ui.PrintHandWithValue(dealer.Hand());
            ui.PrintHandWithValue(player.Hand());
            game.GetOneCard();

            if (dealer.ValueOfCards < 17)
            {
                dealer.GetOneCard(deck);
            }
            dealer.PrintHandWithValue();
            
            ui.Result();
            player.RemoveCardsFromHand();
            dealer.RemoveCardsFromHand();
            
            Console.ReadLine(); 
            Console.Clear();

        }
        
        
        
    }
}

