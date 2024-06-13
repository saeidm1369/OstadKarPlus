using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OstadKarPlus.Base.Infrastructure.DataAccess
{
    public interface IRepository<T> where T : class
    {
        void Add(T model);
        void Update(T model);
        void Delete(T model);
    }
}
