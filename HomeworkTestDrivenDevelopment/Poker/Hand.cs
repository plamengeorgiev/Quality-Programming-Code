using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Hand : IHand
    {
        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            int cardCount = this.Cards.Count;
            string cardSeparator = ", ";

            if (cardCount != 0)
            {
                for (int i = 0; i < cardCount; i++)
                {
                    result.Append(this.Cards[i].ToString());
                    if (i < cardCount - 1)
                    {
                        result.Append(cardSeparator);
                    }
                }
            }

            return result.ToString();
        }
    }
}
