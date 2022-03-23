using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW.CCouch.SharedKernel.Interfaces
{

    /// <summary>
    /// 
    /// </summary>
    public interface IRepository :
        IReadRepository
    {

        /// <summary>
        /// Adds an entity in the database.
        /// </summary>
        /// <param name="entity">
        /// The entity to add.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the <typeparamref name="T" />.
        /// </returns>
        Task<T> AddAsync<T>(
            T entity,
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Adds the given entities in the database
        /// </summary>
        /// <param name="entities">
        /// 
        /// </param>
        /// <param name="cancellationToken">
        /// 
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the <typeparamref name="IEnumerable<T>" />.
        /// </returns>
        Task<IEnumerable<T>> AddRangeAsync<T>(
            IEnumerable<T> entities,
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Removes an entity in the database
        /// </summary>
        /// <param name="entity">The entity to delete.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task DeleteAsync<T>(
            T entity,
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Removes the given entities in the database
        /// </summary>
        /// <param name="entities">The entities to remove.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task DeleteRangeAsync<T>(
            IEnumerable<T> entities,
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Updates an entity in the database
        /// </summary>
        /// <param name="entity">The entity to update.</param>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<T> UpdateAsync<T>(
            T entity,
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Updates an entity in the database
        /// </summary>
        /// <param name="entities">
        /// 
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        Task<IEnumerable<T>> UpdateAsync<T>(
            IEnumerable<T> entities,
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Persists changes to the database.
        /// </summary>
        /// <returns>A task that represents the asynchronous operation.</returns>
        Task<int> SaveChangesAsync(
            CancellationToken cancellationToken = default);

    }

}
