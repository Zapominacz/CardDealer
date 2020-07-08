using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CardDealer.Models;

namespace CardDealer.Controllers
{
    public class CardController : Controller
    {
        private readonly int minimumCards = 1;
        private readonly int maximumCards = 1000;

        public IActionResult Index(int amount = 1, bool sorted = false, bool repeats = false)
        {
            amount = Math.Clamp(amount, minimumCards, maximumCards);

            List<Card> cards = new List<Card>();
            PlayingCardsDeckFactory pcdf = new PlayingCardsDeckFactory();
            Deck deck = pcdf.MakeDeck();
          
            for (int i = 0; i < amount; i++)
            {
                if (deck.Cards.Count == 0)
                    deck = pcdf.MakeDeck();
                cards.Add(deck.GetRandomCard(repeats));
            }

            if (sorted)
                cards.Sort();

            ViewBag.Cards = cards;
            return View();
        }
    }
}