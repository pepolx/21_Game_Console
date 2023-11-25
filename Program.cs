namespace _21_Game_Console;

public static class Program
{
    private static void Main(string[] args)
    {
        Deck deck = new Deck(2);
        Player player = new Player();
        Dealer dealer = new Dealer();
        deck.PrintDeck();
        player.GetStartsCards(deck);
        dealer.GetStartsCards(deck);
        player.PrintDeck();
        dealer.PrintDeck();






    }
}

