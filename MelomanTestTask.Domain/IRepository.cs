using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MelomanTestTask.Domain
{
  /// <summary>
  /// This interface implemented base database operation with generic repository pattern.
  /// </summary>
  public interface IRepository
  {
    /// <summary>
    /// Get entity by primary key.
    /// </summary>
    /// <typeparam name="TEntity">Type of Entity.</typeparam>
    /// <param name="id">PK of Entity.</param>
    /// <returns>Entity or null if not found.</returns>
    TEntity Get<TEntity>(int id) where TEntity : class;

    /// <summary>
    /// Performs add or update operation.
    /// </summary>
    /// <typeparam name="TEntity">Type of Entity.</typeparam>
    /// <param name="entity">Updated entity.</param>
    /// <returns>Returns updated entity.</returns>
    TEntity Update<TEntity>(TEntity entity) where TEntity : class;

    /// <summary>
    /// Performs entity delete operation.
    /// </summary>
    /// <typeparam name="TEntity">Type of Entity.</typeparam>
    /// <param name="id">PK of Entity.</param>
    void Delete<TEntity>(int id) where TEntity : class;

    /// <summary>
    /// Performs apply filter get entities.
    /// </summary>
    /// <typeparam name="TEntity">Type of Entity.</typeparam>
    /// <param name="filter">Expression for filter or null if no filter.</param>
    /// <returns>Returns IEnumerable of Entity.</returns>
    IEnumerable<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class;
  }
}
