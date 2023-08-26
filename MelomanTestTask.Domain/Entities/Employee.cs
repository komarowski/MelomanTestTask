using System.ComponentModel.DataAnnotations;

namespace MelomanTestTask.Domain.Entities
{
  /// <summary>
  /// Employee.
  /// </summary>
  public class Employee
  {
    /// <summary>Employee Id.</summary>
    public int Id { get; set; }

    /// <summary>Employee first name.</summary>
    [MaxLength(30)]
    public string FirstName { get; set; }

    /// <summary>Employee last name.</summary>
    [MaxLength(30)]
    public string LastName { get; set; }

    /// <summary>Employee patronymic.</summary>
    [MaxLength(30)]
    public string Patronymic { get; set; }

    /// <summary>Individual identification number.</summary>
    public long IdentificationNumber { get; set; }

    /// <summary>Company Id where the employee works.</summary>
    public int CompanyId { get; set; }

    public Company Company { get; set; }
  }
}
