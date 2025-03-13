using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6_BlackJack
{
    class Hand
    {
        public List<Card> Cards { get; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }

        public int CalculateValue()
        {
            int total = 0;
            int aceCount = 0;

            foreach (var card in Cards)
            {
                total += card.GetValue();
                if (card.Rank == "A")
                    aceCount++;
            }
            while (total > 21 && aceCount > 0)
            {
                total -= 10;
                aceCount--;
            }
            return total;
        }

        public override string ToString()
        {
            return string.Join(" ", Cards);
        }
    }
}
