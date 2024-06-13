using OstadKarPlus.Domain.Core.UsersAgg.AppService;
using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using OstadKarPlus.Domain.Core.UsersAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarOlus.Domain.AppServices.UsersAgg
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserService _userService;

        public UserAppService(IUserService userService)
        {
            _userService = userService;
        }

        public void Add(AppUser user)
        {
            throw new NotImplementedException();
        }

        public void Delete(AppUser user)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList(int? page, int? pageLength, string? search)
        {
            page = page ?? 1;
            pageLength = pageLength ?? 10;

            int skip = (page.Value - 1) * pageLength.Value;

            return _userService.GetList(skip, pageLength.Value, search);
        }

        public void Update(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
