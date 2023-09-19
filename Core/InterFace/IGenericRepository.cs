using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.InterFace
{
    public interface IGenericRepository<T> where T : class
    {
        IQueryable<T> GetAll();
        Task<T> GetByIdAsync(object id);
        Task Insert(T entity);
        Task Update(T entity,object id);
        Task Delete(object id);
    }
}
