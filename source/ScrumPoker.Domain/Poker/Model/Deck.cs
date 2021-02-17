using System;
using System.Collections.Generic;

using ScrumPoker.Domain.Core.Model;

namespace ScrumPoker.Domain.Poker.Model
{
    public class Deck : Identity
    {
        public Deck(Guid id, List<Card> cards) : base(id)
        {
            Cards = cards;
        }

        public List<Card> Cards { get; }
    }
}