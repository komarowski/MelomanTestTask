using MelomanTestTask.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace MelomanTestTask.Infrastructure
{
  /// <summary>
  /// Implementation of <seealso cref="IRepository"/> for Microsoft SQL Server.
  /// </summary>
  public class MSSQLRepository : IRepository
  {
    private readonly MSSQLContext context;

    /// <summary>
    /// Public constructor for <seealso cref="MSSQLRepository"/>.
    /// </summary>
    /// <param name="context">DbContext for Microsoft SQL Server.</param>
    public MSSQLRepository(MSSQLContext context)
    {
      this.context = context;
    }

    /// <summary>
    /// Implementation of <seealso cref="IRepository.Get{TEntity}(int)"/>
    /// </summary>
    public TEntity Get<TEntity>(int id) where TEntity : class
    {
      return context.Set<TEntity>().Find(id);
    }

    /// <summary>
    /// Implementation of <seealso cref="IRepository.GetList{TEntity}(Expression{Func{TEntity, bool}})"/>
    /// </summary>
    public IEnumerable<TEntity> GetList<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
    {
      if (filter is null)
      {
        return context.Set<TEntity>();
      }
      return context.Set<TEntity>().Where(filter);
    }

    /// <summary>
    /// Implementation of <seealso cref="IRepository.Delete{TEntity}(int)"/>
    /// </summary>
    public void Delete<TEntity>(int id) where TEntity : class
    {
      var entity = context.Set<TEntity>().Find(id);
      if (entity != null)
      {
        context.Set<TEntity>().Remove(entity);
        context.SaveChanges();
      }
    }

    /// <summary>
    /// Implementation of <seealso cref="IRepository.Update{TEntity}(TEntity)"/>
    /// </summary>
    public TEntity Update<TEntity>(TEntity entity) where TEntity : class
    {
      context.Set<TEntity>().AddOrUpdate(entity);
      context.SaveChanges();
      return entity;
    }
  }
}
