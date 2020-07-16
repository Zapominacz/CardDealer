using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;

namespace CardDealer.Models
{
    public class Deck
    {
        public List<Card> Cards { get; private set; }

        public Deck()
        {
            Cards = new List<Card>();
        }
        
        public Deck(List<Card> cards)
        {
            Cards = cards; 
        }

        public bool IsEmpty()
        {
            return Cards.Count == 0;
        }
        public Card GetRandomCard(bool keepInDeck)
        {
            if (Cards.Count == 0)
                return null;

            int index = RandomNumberGenerator.GetInt32(this.Cards.Count());
            Card picked = Cards[index];
            if (!keepInDeck)
                Cards.RemoveAt(index);
            return picked;
        }
    }
}
