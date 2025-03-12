using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review_session6_BlackJack
{
    class Card
    {
        public string Shape { get; }
        public string Rank { get; }

        public Card(string shape, string rank)
        {
            Shape = shape;
            Rank = rank;
        }

        public int GetValue()
        {
            if (Rank == "A")
                return 11;

            if (Rank == "K" || Rank == "Q")
                return 10;

            return int.Parse(Rank);
        }

        public override string ToString()
        {
            return $"{Rank}{Shape}";
        }
    }
}
