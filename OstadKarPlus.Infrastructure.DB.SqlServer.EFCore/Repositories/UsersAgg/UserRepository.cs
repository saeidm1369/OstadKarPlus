using OstadKarPlus.Base.Infrastructure.DataAccess;
using OstadKarPlus.Domain.Core.UsersAgg.Data;
using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Repositories.UsersAgg
{
    public class UserRepository : BaseRepository<AppUser>, IUserRepository
    {
        public UserRepository(OstadKarPlusDBContext dbContext) : base(dbContext)
        {
        }

        public List<AppUser> List(int skip, int take, string? search)
        {
            IQueryable<AppUser> query = Entities.AsQueryable<AppUser>();

            if (search != null)
            {
                query = query.Where(x=>x.FistName.Equals(search) || x.LastName.Equals(search));
            }

            return query.Skip(skip).Take(take).ToList();
        }
    }
}
