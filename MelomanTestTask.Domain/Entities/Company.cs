using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MelomanTestTask.Domain.Entities
{
  /// <summary>
  /// Company.
  /// </summary>
  public class Company
  {
    /// <summary>Company Id.</summary>
    public int Id { get; set; }

    /// <summary>Company name.</summary>
    [MaxLength(50)]
    public string Name { get; set; }

    /// <summary>Tax identification number.</summary>
    public long TaxNumber { get; set; }

    /// <summary>Physical adress.</summary>
    [MaxLength(100)]
    public string Address { get; set; }

    /// <summary>Additional note.</summary>
    [MaxLength(200)]
    public string Note { get; set; }

    /// <summary>Company employees.</summary>
    public ICollection<Employee> Employees { get; set; }

    public Company()
    {
      Employees = new List<Employee>();
    }
  }
}
