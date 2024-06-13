using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Domain.Core.UsersAgg.AppService
{
    public interface IUserAppService
    {
        public void Add(AppUser user);
        public void Update(AppUser user);
        public void Delete(AppUser user);
        public List<AppUser> GetList(int? page, int? pageLength, string? search);
    }
}
