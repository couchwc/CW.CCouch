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
    public interface IReadRepository
    {

        /// <summary>
        /// Finds an entity with the given unique id value.
        /// </summary>
        /// <typeparam name="T">
        /// The type of entity.
        /// </typeparam>
        /// <param name="id">
        /// The value of the unique id for the entity to be found.
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the <typeparamref name="T" />.
        /// </returns>
        Task<T> GetItemByIdAsync<T>(
            Guid id, 
            CancellationToken cancellationToken = default) 
            where T : IEntity;

        /// <summary>
        /// Get all entities.
        /// </summary>
        /// <typeparam name="T">
        /// The type of entity.
        /// </typeparam>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the <typeparamref name="T" />.
        /// </returns>
        Task<T> GetItemsAsync<T>(
            CancellationToken cancellationToken = default)
            where T : IEntity;

        /// <summary>
        /// Get all entities.
        /// </summary>
        /// <typeparam name="T">
        /// The type of entity.
        /// </typeparam>
        /// <param name="instructions">
        /// 
        /// </param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// The task result contains the <typeparamref name="T" />.
        /// </returns>
        Task<T> GetItemsAsync<T>(
            object instructions, // Think includes and where statements, etc.
            CancellationToken cancellationToken = default)
            where T : IEntity;

    }

}
