using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OstadKarPlus.Domain.Core.UsersAgg.Entities;
using OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Configurations.UsersAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Contexts
{
    public class OstadKarPlusDBContext : IdentityDbContext<AppUser>
    {
        public OstadKarPlusDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
            base.OnModelCreating(builder);

        }
    }
}
