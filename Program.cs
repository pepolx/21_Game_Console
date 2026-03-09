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

        var playerWins = 0;
        var dealerWins = 0;
        var draws = 0;

        while (game.IsEnoughCardsInDeck(deck))
        {
            player.GetStartsCards(deck);
            dealer.GetStartsCards(deck);

            ui.PrintHandWithValue(dealer.Hand(), "Diler");
            ui.PrintHandWithValue(player.Hand(), "Gracz");
            game.GetOneCard();

            while (dealer.ValueOfCards < 17)
            {
                dealer.GetOneCard(deck);
            }

            dealer.PrintHandWithValue();
            player.PrintHandWithValue();
            ui.Result();

            if (player.ValueOfCards > 21 || (dealer.ValueOfCards <= 21 && dealer.ValueOfCards > player.ValueOfCards))
            {
                dealerWins++;
            }
            else if (dealer.ValueOfCards == player.ValueOfCards)
            {
                draws++;
            }
            else
            {
                playerWins++;
            }

            Console.WriteLine($"Wynik sesji -> Gracz: {playerWins}, Diler: {dealerWins}, Remisy: {draws}");

            player.RemoveCardsFromHand();
            dealer.RemoveCardsFromHand();

            Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine("Koniec gry - za mało kart w talii na kolejną rundę.");
    }
}
