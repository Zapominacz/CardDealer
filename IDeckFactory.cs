using CardDealer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardDealer
{
    public interface IDeckFactory
    {
        public Deck MakeDeck();
    }
}
