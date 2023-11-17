using System;
using System.Collections.Generic;

namespace _21_Game_Console;

public class Deck
{
    public int numberOfCards = 52;

    private List<Card> deckOfCards;

    public Deck()
    {
        Initialize();
    }
    
    public List<Card> Shuffle(List<Card> deck)
    {
        Random rng = new Random();

        
        while(numberOfCards > 1)
        {
            numberOfCards--;
            int k = rng.Next(numberOfCards + 1);
            (deck[k], deck[numberOfCards]) = (deck[numberOfCards], deck[k]);
        }

        return deck;
    }
    
    public List<Card> GetDeck()
    {
        List<Card> deck = new List<Card>();

        for (int i = 1; i < 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                deck.Add(new Card((Suit)j, (Face)i));
            }
        }

        return deck;
    }

    private void Initialize()
    {
        deckOfCards = GetDeck();
        Shuffle(deckOfCards);

    }

    public static void PrintDeck(Deck deck)
    {
        var x = 0;
        foreach (var card in deck.deckOfCards)
        {
            
            Console.WriteLine(card.Suit + "   " + card.Face + "    " + card.Symbol +
                              "    " + card.Value);
            x++;
            Console.WriteLine(x);

        }
    }
    
}