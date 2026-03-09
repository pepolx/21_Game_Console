namespace _21_Game_Console;

public static class HandValueCalculator
{
    public static int CalculateValue(List<Card> hand)
    {
        var total = 0;
        var aces = 0;

        foreach (var card in hand)
        {
            total += card.Value;
            if (card.Face == Face.Ace)
            {
                aces++;
            }
        }

        while (total > 21 && aces > 0)
        {
            total -= 10;
            aces--;
        }

        return total;
    }
}
