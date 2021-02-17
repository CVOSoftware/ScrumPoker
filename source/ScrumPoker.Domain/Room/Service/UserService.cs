using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Interfaces.Service;
using ScrumPoker.Domain.Room.Interface.Repository;
using ScrumPoker.Domain.Room.Interface.Service;
using ScrumPoker.Domain.Room.Model;

namespace ScrumPoker.Domain.Room.Service
{
    public class UserService : IUserService
    {
        private readonly IDataService _dataService;

        public UserService(IDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
