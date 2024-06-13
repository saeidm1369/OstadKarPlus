using OstadKarPlus.Domain.Core.UsersAgg.Data;
using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using OstadKarPlus.Domain.Core.UsersAgg.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Domain.Services.UsersAgg
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(AppUser user)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(AppUser user)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> GetList(int skip, int take, string? search)
        {
            return _userRepository.List(skip, take, search);
        }

        public void UpdateUser(AppUser user)
        {
            throw new NotImplementedException();
        }
    }
}
