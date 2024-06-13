using Microsoft.Extensions.DependencyInjection;
using OstadKarOlus.Domain.AppServices.UsersAgg;
using OstadKarPlus.Domain.Core.UsersAgg.AppService;
using OstadKarPlus.Domain.Core.UsersAgg.Data;
using OstadKarPlus.Domain.Core.UsersAgg.Service;
using OstadKarPlus.Domain.Services.UsersAgg;
using OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Repositories.UsersAgg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Infrastructure.Extensions
{
    public static class UserExtensions
    {
        public static void AddUsers(this IServiceCollection services)
        {
            //Repositories
            services.AddTransient<IUserRepository, UserRepository>();

            //Services
            services.AddTransient<IUserService, UserService>();

            //AppServices
            services.AddTransient<IUserAppService, UserAppService>();

        }
    }
}
