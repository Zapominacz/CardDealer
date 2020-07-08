using CardDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public abstract class DeckFactory : IDeckFactory
    {
        public abstract Deck MakeDeck();
    }
}
