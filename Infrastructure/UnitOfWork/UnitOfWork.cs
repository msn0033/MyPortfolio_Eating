using Core.InterFace;
using Infrastructure.Data;
using Infrastructure.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly Context _context;
        private readonly IGenericRepository<T> _entity;
        public UnitOfWork(Context context)
        {
            this._context = context;
          
        }
        public IGenericRepository<T> Entity => _entity ?? new GenericRepository<T>(_context);

        public async Task SaveAsync()
        {
           await _context.SaveChangesAsync();
        }
    }
}
