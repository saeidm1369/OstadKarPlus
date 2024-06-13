using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Domain.Core.UsersAgg.Service
{
    public interface IUserService
    {
        public void AddUser(AppUser user);
        public void UpdateUser(AppUser user);
        public void DeleteUser(AppUser user);
        public List<AppUser> GetList(int skip, int take, string? search);
    }
}
