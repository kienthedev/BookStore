using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace FA.BookStore.Core.Interfaces
{
    /// <summary>
    /// Provides generic data access methods for entities in the book store.
    /// </summary>
    /// <typeparam name="T">The type of entity.</typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Retrieves a list of entities from the repository with optional filtering, sorting, and inclusion of related properties.
        /// </summary>
        /// <param name="filter">An optional filter expression to apply.</param>
        /// <param name="orderBy">An optional ordering function to apply.</param>
        /// <param name="includeProps">An optional array of related properties to include.</param>
        /// <returns>A list of entities that match the specified criteria.</returns>
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, params string[] includeProps);

        /// <summary>
        /// Finds an entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the entity.</param>
        /// <returns>The found entity or null if not found.</returns>
        T? Find(object id);

        /// <summary>
        /// Adds a new entity to the repository.
        /// </summary>
        /// <param name="entity">The entity to add.</param>
        void Add(T entity);

        /// <summary>
        /// Updates an entity in the repository.
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        void Update(T entity);

        /// <summary>
        /// Deletes an entity from the repository.
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        void Delete(T entity);

        /// <summary>
        /// Saves changes made to the repository.
        /// </summary>
        void Save();
    }
}