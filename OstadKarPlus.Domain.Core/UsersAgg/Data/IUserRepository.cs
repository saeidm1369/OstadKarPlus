using OstadKarPlus.Base.Infrastructure.DataAccess;
using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Domain.Core.UsersAgg.Data
{
    public interface IUserRepository : IRepository<AppUser>
    {
        public List<AppUser> List(int skip, int take, string? sreach);
    }
}
