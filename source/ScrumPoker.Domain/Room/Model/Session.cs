using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumPoker.Domain.Room.Model
{
    public class Session
    {
        public Guid Id { get; }

        public User Owner { get; set; }

        public Setting Setting { get; set; }

        public List<User> Users { get; set; }
    }
}