using ScrumPoker.Domain.Poker.Model;

namespace ScrumPoker.Domain.Room.Model
{
    public class Setting
    {
        public Deck Deck { get; set; }

        public Shirt Shirt { get; set; }

        public Lifetime Lifetime { get; set; }

        public Size Size { get; set; }

        public Privacy Privacy { get; set; }
    }
}
