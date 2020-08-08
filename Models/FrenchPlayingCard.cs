using System;

namespace CardDealer.Models
{
    public class FrenchPlayingCard : Card
    {
        private Suits _suit;
        public Suits Suit
        {
            get
            {
                return this._suit;
            }
            private set
            {
                if ((int)value < 0 || (int)value > 4)
                    _suit = 0;
                else
                    _suit = value;
            }
        }

        private int _rank;
        public int Rank
        {
            get
            {
                return this._rank;
            }
            private set
            {
                _rank = Math.Clamp(value, 2, 15);
            }
        }

        public FrenchPlayingCard(Suits suit, int rank, string imageUrl)
        {
            this.Suit = suit;
            this.Rank = rank;
            this.CardUrl = imageUrl;
        }

        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            FrenchPlayingCard otherCard = obj as FrenchPlayingCard;

            if (otherCard == null)
                throw new ArgumentException("Object is not a card.");

            int rankCompareResult = this.Rank.CompareTo(otherCard.Rank);
            return rankCompareResult == 0 ? this.Suit.CompareTo(otherCard.Suit) : rankCompareResult;
        }

        public enum Suits
        {
            Misc = 0,
            Clubs = 1,
            Diamonds = 2,
            Hearts = 3,
            Spades = 4,
        }
    }
}
