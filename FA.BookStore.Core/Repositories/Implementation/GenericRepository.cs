using FA.BookStore.Core.Interfaces;
using FA.BookStore.Core.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FA.BookStore.Core.Repositories.Implementation
{
    /// <summary>
    /// Provides generic data access methods for entities in the book store.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        internal readonly DbSet<T> _dbSet;
        internal readonly BookStoreContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericRepository{T}"/> class.
        /// </summary>
        /// <param name="context">The database context for the book store.</param>
        public GenericRepository(BookStoreContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        public void Delete(T entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Finds an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity.</param>
        /// <returns>The found entity or null if not found.</returns>
        public T? Find(object id)
        {
            T? entity = _dbSet.Find(id);
            if (entity == null)
            {
                return null;
            }
            return entity;
        }

        /// <summary>
        /// Retrieves a list of entities from the repository with optional filtering, sorting, and inclusion of related properties.
        /// </summary>
        /// <param name="filter">An optional filter expression to apply.</param>
        /// <param name="orderBy">An optional ordering function to apply.</param>
        /// <param name="includeProps">An optional array of related properties to include.</param>
        /// <returns>A list of entities that match the specified criteria.</returns>
        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, params string[] includeProps)
        {
            IQueryable<T> query = _dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProps.Length > 0)
            {
                foreach (var prop in includeProps)
                {
                    query = query.Include(prop);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }

        /// <summary>
        /// Updates an entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Saves changes made to the repository.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
