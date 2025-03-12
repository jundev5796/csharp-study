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
        }

        private List<Card> CreateDeck()
        {
            List<Card> newDeck = new List<Card>();

            string[] shapes = ("♠️")
        }
    }
}
