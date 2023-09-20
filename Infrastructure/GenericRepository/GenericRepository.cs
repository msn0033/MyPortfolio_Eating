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
     

        public IQueryable<T> GetAll()
        {
            return _table.AsQueryable();
        }

        public async Task<T> GetByIdAsync(object id)
        {
            var x= await _table!.FindAsync(id);
            return x!;
        }

        public async Task InsertAsync(T entity)
        {
            await _table.AddAsync(entity);
        }

        public async Task Update(T entity ,object id)
        {
            T ex=await GetByIdAsync(id);
            ex = entity;
           _table.Update(ex);
        }
        public async Task Delete(object id)
        {
            T ex = await GetByIdAsync(id);
            _table.Remove(ex);
        }
    }
}
