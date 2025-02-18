using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.DAL;

namespace ToDoList.Infrastructure.Dal.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _context;
        private DbSet<TEntity> _dbSet; 

        public Repository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }
        public virtual async Task AddAsync(TEntity entity)
        {
           await _dbSet.AddAsync(entity);
           await _context.SaveChangesAsync();
        }

        public virtual async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id)?? throw new KeyNotFoundException();
            _dbSet.Remove(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return _dbSet.AsEnumerable();
        }

        public virtual IQueryable<TEntity> GetAllQueryable()
        {
            return _dbSet.AsQueryable();
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
           return await _dbSet.FindAsync(id) ?? throw new KeyNotFoundException();
        }

        public virtual async Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate)
        { 
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public virtual async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
