using CardDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public static class CardList
    {
        public static List<Card> DrawCards(DeckFactory deckFactory, int amount, bool sorted, bool repeats)
        {
            List<Card> cards = new List<Card>();
            Deck deck = deckFactory.MakeDeck();

            for (int i = 0; i < amount; i++)
            {
                if (deck.IsEmpty())
                    deck = deckFactory.MakeDeck(); //assumption - a newly-made deck must have cards in it. 
                cards.Add(deck.GetRandomCard(repeats));
            }

            if (sorted)
                cards.Sort();

            return cards;
        }
    }
}
