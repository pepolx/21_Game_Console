using System;

namespace _21_Game_Console;

class Program
{
    static void Main(string[] args)
    {
        DeckOfCards deck = new DeckOfCards();
        
        
        
        foreach (var card in deck.Shuffle(deck.GetDeck()))
        {
            Console.WriteLine(card.Suit + "   " + card.Face + "    " + card.Symbol +
                              "    " + card.Value);
        }        

    }
}

