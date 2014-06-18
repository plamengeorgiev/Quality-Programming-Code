using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Card : ICard
    {
        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public CardFace Face { get; private set; }

        public CardSuit Suit { get; private set; }

        public override string ToString()
        {
            string cardSuit = this.GetCardSuitAsString();
            string cardFace = this.GetCardFaceAsString();
            string result = cardFace + cardSuit;
            return result;
        }

        public int CompareTo(ICard otherCard)
        {
            Card inputCard = otherCard as Card;

            if (this.Face != inputCard.Face)
            {
                return (int)this.Face - (int)inputCard.Face;
            }

            if (this.Suit != inputCard.Suit)
            {
                return (int)this.Suit - (int)inputCard.Suit;
            }

            return 0;
        }

        private string GetCardFaceAsString()
        {
            string cardFace = string.Empty;
            int cardFaceAsInt = (int)this.Face;
            if (cardFaceAsInt <= 10)
            {
                cardFace = cardFaceAsInt.ToString();
            }
            else
            {
                cardFace = this.Face.ToString().Substring(0, 1);
            }

            return cardFace;
        }

        private string GetCardSuitAsString()
        {
            string cardSuit = string.Empty;
            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    cardSuit = "♣";
                    break;
                case CardSuit.Diamonds:
                    cardSuit = "♦";
                    break;
                case CardSuit.Hearts:
                    cardSuit = "♥";
                    break;
                case CardSuit.Spades:
                    cardSuit = "♠";
                    break;
                default:
                    throw new ArgumentException("Unknown suit: " + this.Suit);
            }

            return cardSuit;
        }
    }
}
