using CardDealer.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public class PlayingCardsDeckFactory : DeckFactory
    {
        private readonly String cardPath = "/CardsImages/";
        private readonly String blackJokerName = "black_joker.png";
        private readonly String redJokerName = "red_joker.png";

        public override Deck MakeDeck()
        {
            List<Card> cards = new List<Card>();
            for (int i = 2; i <= 14; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    cards.Add(new FrenchPlayingCard((FrenchPlayingCard.Suits)j, i, cardResourceName(cardPath, i, j)));
                }
            }
            cards.Add(new FrenchPlayingCard((FrenchPlayingCard.Suits)0, 15, cardResourceName(cardPath, blackJokerName)));
            cards.Add(new FrenchPlayingCard((FrenchPlayingCard.Suits)0, 15, cardResourceName(cardPath, redJokerName)));

            return new Deck(cards);
        }

        private String cardResourceName(string prefix, string cardString)
        {
            return this.cardPath + cardString;
        }

        private String cardResourceName(string prefix, int cardRank, int cardSuit)
        {
            return this.cardPath + $"{cardRank}_{cardSuit}.png";
        }

    }
}
