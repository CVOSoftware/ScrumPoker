using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrumPoker.Domain.Core.Interfaces.Repository
{
    public interface IRepository<T>
    {
        Task<T> Get(Guid id);
    }
}
