﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CardDealer.Models;

namespace CardDealer.Controllers
{



    public class CardController : Controller
    {
        private readonly int minimumCards = 1;
        private readonly int maximumCards = 1000;

        public IActionResult Index(int amount = 100000, bool sorted = false, bool repeats = false)
        {
            amount = Math.Clamp(amount, minimumCards, maximumCards);

            List<Card> cards = CardList.DrawCards(new PlayingCardsDeckFactory(), amount, sorted, repeats);
            return View(cards); // Use Ok(cards)
        }
    }
}
