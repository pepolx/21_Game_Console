using System;
using System.Collections.Generic;

namespace _21_Game_Console;

public class DeckOfCards
{
    public int numberOfCards = 52;

    private List<Card> Cards;

    public DeckOfCards()
    {
        Initialize();
    }
    
    public List<Card> Shuffle(List<Card> deck)
    {
        Random rng = new Random();

        int n = deck.Count;
        while(n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            Card card = deck[k];
            deck[k] = deck[n];
            deck[n] = card;
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
        
    }
}