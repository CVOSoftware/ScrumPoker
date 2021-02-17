using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ScrumPoker.Domain.Core.Interfaces.Service;
using ScrumPoker.Domain.Core.Model;
using ScrumPoker.Domain.Room.Interface.Service;
using ScrumPoker.Domain.Room.Model;
using ScrumPoker.Domain.Room.Model.Request;
using ScrumPoker.Domain.Room.Model.Response;

namespace ScrumPoker.Domain.Room.Service
{
    public class SessionService : ISessionService
    {
        private readonly IDataService _dataService;

        private readonly ISettingService _settingService;

        public SessionService(IDataService dataService, ISettingService settingService)
        {
            _dataService = dataService;
            _settingService = settingService;
        }

        public async Task<Result<SessionInfo>> Init(SettingInfo model)
        {
            var settingServiceResult = await _settingService.Create(model);

            if(settingServiceResult.Status == false)
            {
                return Result<SessionInfo>.False(settingServiceResult.ErrorId);
            }

            var preparedSessionModel = new Session
            {
                Setting = settingServiceResult.Value
            };
            var createdSessionModel = await _dataService.SessionRepository.Add(preparedSessionModel);
            var info = new SessionInfo
            {
                Id = createdSessionModel.Id
            };
            var result = Result<SessionInfo>.True(info);

            return result;
        }

        public async Task<Result<SessionInfo>> Get(Guid id)
        {
            var model = await _dataService.SessionRepository.Get(id);

            if(model == null)
            {
                return Result<SessionInfo>.False(ISessionService.ThrowSessionGettingError);
            }

            var info = new SessionInfo
            {
                Id = model.Id
            };
            var result = Result<SessionInfo>.True(info);

            return result;
        }

        public async Task<Result> Close(Guid id)
        {
            var model = await _dataService.SessionRepository.Get(id);

            if(model == null)
            {
                return Result.False(ISessionService.ThrowSessionDeleteError);
            }

            await _dataService.SessionRepository.Delete(id);

            var result = Result.True();

            return result;
        }
    }
}