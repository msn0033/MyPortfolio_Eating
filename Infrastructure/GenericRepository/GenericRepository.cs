using Core.InterFace;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly Context _context;
        private DbSet<T> _table;

        public GenericRepository(Context context)
        {
            this._context = context;
            _table=_context.Set<T>();
        }
        public async Task Delete(object id)
        {
          T ex=await  GetById(id);
            _table.Remove(ex);
        }

        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }

        public async Task<T> GetById(object id)
        {
            return await _table!.FindAsync(id);
        }

        public async Task Insert(T entity)
        {
            await _table.AddAsync(entity);
        }

        public void Update(T entity)
        {
           _table.Update(entity);
        }
    }
}
