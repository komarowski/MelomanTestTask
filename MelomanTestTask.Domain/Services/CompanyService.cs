using MelomanTestTask.Domain.Entities;
using System.Collections.Generic;

namespace MelomanTestTask.Domain.Services
{
  /// <summary>
  /// Logic of working with <see cref="Company"/> entity.
  /// </summary>
  public class CompanyService
  {
    private readonly IRepository repository;

    /// <summary>
    /// Public constructor for <seealso cref="CompanyService"/>.
    /// </summary>
    /// <param name="projectRepository"><seealso cref="IRepository"/> implementation.</param>
    public CompanyService(IRepository projectRepository)
    {
      this.repository = projectRepository;
    }

    /// <summary>
    /// Get all companies.
    /// </summary>
    /// <returns>IEnumerable of Company.</returns>
    public IEnumerable<Company> GetCompanytList()
    {
      return repository.GetList<Company>(null);
    }

    /// <summary>
    /// Gets company by company Id.
    /// </summary>
    /// <param name="companyId">Company Id.</param>
    /// <returns>Company or null if not found.</returns>
    public Company Get(int companyId)
    {
      return repository.Get<Company>(companyId);
    }

    /// <summary>
    /// Adds or updates a company record.
    /// </summary>
    /// <param name="company">Company information.</param>
    /// <returns>Saved company.</returns>
    public Company Update(Company company)
    {
      return repository.Update(company);
    }

    /// <summary>
    /// Deletes an company record.
    /// </summary>
    /// <param name="id">Company Id.</param>
    public void Delete(int id)
    {
      repository.Delete<Company>(id);
    }
  }
}
