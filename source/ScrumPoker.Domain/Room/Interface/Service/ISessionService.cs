using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Model;
using ScrumPoker.Domain.Room.Model.Request;
using ScrumPoker.Domain.Room.Model.Response;

namespace ScrumPoker.Domain.Room.Interface.Service
{
    public interface ISessionService
    {
        static Guid ThrowSessionGettingError = Guid.Parse("4af7f272-9d70-4e47-8299-43b683ff883d");

        static Guid ThrowSessionDeleteError = Guid.Parse("41c88cc6-c76b-417d-b784-c5180abe09c2");

        Task<Result<SessionInfo>> Init(SettingInfo model);

        Task<Result<SessionInfo>> Get(Guid id);

        Task<Result> Close(Guid id);
    }
}
