using System;

using ScrumPoker.Domain.Core.Model;

namespace ScrumPoker.Domain.Poker.Model
{
    public class Shirt : Identity
    {
        public Shirt(Guid id, string style) : base(id)
        {
            Style = style;
        }

        public string Style { get; set; }
    }
}