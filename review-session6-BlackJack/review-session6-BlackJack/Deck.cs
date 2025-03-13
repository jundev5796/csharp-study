using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6_BlackJack
{
    class Deck
    {
        private List<Card> cards;
        private int deckIndex;
        private Random random;

        public Deck()
        {
            random = new Random();
            ResetDeck();
        }

        private List<Card> CreateDeck()
        {
            List<Card> newDeck = new List<Card>();

            string[] shapes = { "♠", "♥", "◆", "♣" };
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };

            foreach (var shpes in shapes)
            {
                foreach (var rank in ranks)
                {
                    newDeck.Add(new Card(rank, shpes));
                }
            }
            return newDeck;
        }



        private void Shuffle()
        {
            int n = cards.Count;

            for (int i = 0; i < n; i++)
            {
                int randomIndex = random.Next(i, n);
                Card temp = cards[i];
                cards[i] = cards[randomIndex];
                cards[randomIndex] = temp;
            }
        }

        private void ResetDeck()
        {
            cards = CreateDeck();
            Shuffle();
            deckIndex = 0;
        }

        public Card DrawCard()
        {
            if (deckIndex >= cards.Count)
            {
                Console.WriteLine("모든 카드를 사용하여 덱을 다시 섞습니다.");
                ResetDeck();
            }
            Card drawCard = cards[deckIndex++];
            return drawCard;
        }
    }
}
