using Microsoft.EntityFrameworkCore;
using OstadKarPlus.Infrastructure.DB.SqlServer.EFCore.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Base.Infrastructure.DataAccess
{
    public class BaseRepository<TEntity> where TEntity : class
    {
        protected readonly OstadKarPlusDBContext DBContext;
        protected readonly DbSet<TEntity> Entities;
        public BaseRepository(OstadKarPlusDBContext dbContext)
        {
            DBContext = dbContext;
            Entities = DBContext.Set<TEntity>();
        }

        public void Add(TEntity model)
        {
            DBContext.Add(model);
            DBContext.SaveChanges();
        }

        public void Update(TEntity model)
        {
            DBContext.Update(model);
            DBContext.SaveChanges();
        }

        public void Delete(TEntity model)
        {
            DBContext.Remove(model);
            DBContext.SaveChanges();
        }
    }
}
