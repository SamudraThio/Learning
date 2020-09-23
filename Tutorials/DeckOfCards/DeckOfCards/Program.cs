using System;

namespace DeckOfCards
{
    enum Suit {  Hearts, Diamonds, Spades, Clubs };

    struct Card
    {
        public readonly int FaceValue;
        public readonly Suit Suit;

        public Card(int faceValue, Suit suit)
        {
            FaceValue = faceValue;
            Suit = suit;
        }
    }
    class CardsOnTheDesk
    {
        int howMany;

        Card[] theCards = new Card[8];
        
        public Suit this[int faceValue]
        {
            get => FindTheSuitOfFaceValue(faceValue);

            set => AddOrReplace(new Card(faceValue, value));
        }

        public CardsOnTheDesk()
        {
            theCards[0] = new Card(5, Suit.Hearts);
            theCards[1] = new Card(13, Suit.Diamonds);
            theCards[2] = new Card(10, Suit.Diamonds);
            theCards[3] = new Card(12, Suit.Spades);

            howMany = 4;
        }
        public Suit FindTheSuitOfFaceValue(int faceValue)
        {
            for (int i = 0; i < howMany; i++)
            {
                if (theCards[i].FaceValue == faceValue)
                {
                    return theCards[0].Suit;
                }
            }
            throw new CardNotFoundException($"Didn't find card with face value {faceValue}.");
        }

        public void AddOrReplace(Card newCard)
        {
            bool foundMatchingCard = false;

            for (int i = 0; i < howMany; i++)
            {
                if (newCard.FaceValue == theCards[i].FaceValue)
                {
                    foundMatchingCard = true;
                    theCards[i] = newCard;
                }
            }
            if (!foundMatchingCard)
            {
                theCards[howMany++] = newCard;
            }
        }
    }
    public class Program
    { 
        static void Main(string[] args)
        {
            var cardsOnDesk = new CardsOnTheDesk();

            // cardsOnDesk.AddOrReplace(new Card(5, Suit.Hearts));
            // cardsOnDesk.AddOrReplace(new Card(13, Suit.Diamonds));
            // cardsOnDesk.AddOrReplace(new Card(10, Suit.Diamonds));
            // cardsOnDesk.AddOrReplace(new Card(10, Suit.Spades));
            // cardsOnDesk.AddOrReplace(new Card(12, Suit.Clubs));

        
            cardsOnDesk[5] = Suit.Hearts;
            cardsOnDesk[13] = Suit.Diamonds;
            cardsOnDesk[10] = Suit.Diamonds;
            cardsOnDesk[10] = Suit.Spades;
            cardsOnDesk[12] = Suit.Clubs;

            cardsOnDesk[4] = Suit.Diamonds;

            // Suit foundSuit = cardsOnDesk.FindTheSuitOfFaceValue(2);
            Console.WriteLine(cardsOnDesk[4]);
        }        
    }
}
