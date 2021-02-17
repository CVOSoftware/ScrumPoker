using System;

namespace ScrumPoker.Domain.Room.Model
{
    public class Message
    {
        public User User { get; set; }

        public string Content { get; set; }

        public DateTime Created { get; set; }
    }
}
