using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CankutayUcarAuthServer.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CankutayUcarAuthServer.Data.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity>
    where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _entities;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var entity = await _entities.FindAsync(id);
            if (entity != null)
            {
                _context.Entry(entity).State = EntityState.Detached;
            }
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> expression)
        {
            return _entities.Where(expression);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
