using static _21_Game_Console.Suit;
using static _21_Game_Console.Face;

namespace _21_Game_Console
{

    public enum Suit
    {
        Clubs,
        Spades,
        Diamonds,
        Hearts,
    }

    public enum Face
    {
        Ace = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }

    public class Card
    {

        public Suit Suit { get; }
        public Face Face { get; }
        public int Value { get; }
        public char Symbol { get; }

        public Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;

            switch (Suit)
            {
                case Clubs:
                    Symbol = '♣';
                    break;
                case Spades:
                    Symbol = '♠';
                    break;
                case Diamonds:
                    Symbol = '♦';
                    break;
                case Hearts:
                    Symbol = '♥';
                    break;
            }

            switch (Face)
            {
                case Ten:
                case Jack:
                case Queen:
                case King:
                    Value = 10;
                    break;
                case Ace:
                    Value = 11;
                    break;
                default:
                    Value = (int)Face;
                    break;

            }
        }


    }
}