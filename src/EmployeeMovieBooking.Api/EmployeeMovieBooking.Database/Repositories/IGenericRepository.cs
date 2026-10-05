using EmployeeMovieBooking.Database.Abstractions.Entities;
using EmployeeMovieBooking.Database.Shared;
using Microsoft.EntityFrameworkCore.Storage;
using System.Linq.Expressions;

namespace EmployeeMovieBooking.Database.Repositories
{
    public interface IGenericRepository<TEntity, TKey> where TEntity : class, IDomainEntity<TKey>
    {
        /// <summary>
        /// Return all entities within this DbSet. WARNING: performance will severely degrade with large dataset.
        /// </summary>
        /// <returns></returns>
        Task<IReadOnlyList<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Get all entities within this DbSet that match the predicate. WARNING: performance will severely degrade with large dataset.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<IReadOnlyList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        Task<IReadOnlyList<TEntity>> GetAllAsyncUntracked(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Get paginated result. NOTE: AsNoTracking is used by default.
        /// </summary>
        Task<PagedResult<TEntity>> GetPagingAsync(int pageIndex, int pageSize, CancellationToken cancellationToken);

        /// <summary>
        /// Remove an entity directly by id. WARNING: this will skip EFCore change tracking system.
        /// </summary>
        Task<TEntity?> GetByIdAsync(TKey id, CancellationToken cancellationToken);

        Task<TEntity?> GetByIdAsyncUntracked(TKey id);

        /// <summary>
        /// Get an entity by predicate. WARNING: this will skip EFCore change tracking system.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        Task<TEntity?> GetAsyncUntracked(Expression<Func<TEntity, bool>> predicate);

        /// <summary>
        /// Create a new entity. WARNING: this will skip EFCore change tracking system.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TKey> CreateAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Update an existing entity. WARNING: this will skip EFCore change tracking system.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Delete an entity. WARNING: this will skip EFCore change tracking system.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(TEntity entity, CancellationToken cancellationToken);

        /// <summary>
        /// Delete an entity directly by id. WARNING: this will skip EFCore change tracking system.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<int> DeleteByIdAsync(TKey id, CancellationToken cancellationToken);

        Task<IDbContextTransaction> BeginDbTransaction();
    }
}
