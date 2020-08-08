using System;

namespace CardDealer.Models
{
    public abstract class Card : IComparable
    {
        public String CardUrl { get; protected set; }
        public abstract int CompareTo(object obj);
    }
}
