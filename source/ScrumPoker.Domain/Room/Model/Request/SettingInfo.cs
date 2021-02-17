using System;

namespace ScrumPoker.Domain.Room.Model.Request
{
    public class SettingInfo
    {
        public Guid DeckId { get; set; }

        public Guid ShirtId { get; set; }

        public Guid LifetimeId { get; set; }

        public Guid SizeId { get; set; }

        public Privacy Privacy { get; set; }

        public bool Validate()
        {
            return Privacy != null
                && string.IsNullOrEmpty(Privacy.Password) == false
                && string.IsNullOrWhiteSpace(Privacy.Password) == false;
        }
    }
}
