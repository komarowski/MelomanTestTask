using MelomanTestTask.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity;

namespace MelomanTestTask.Infrastructure
{
  /// <summary>
  /// DbContext for Microsoft SQL Server.
  /// </summary>
  public class MSSQLContext : DbContext
  {
    /// <summary>
    /// Static constructor to create an initial database.
    /// </summary>
    static MSSQLContext()
    {
      Database.SetInitializer<MSSQLContext>(new ContextInitializer());
    }

    /// <summary>
    /// Public constructor for <seealso cref="MSSQLContext"/>.
    /// </summary>
    public MSSQLContext()
      : base("MelomanTestTaskDb")
    {
    }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);
      //Setting up a foreign key for Employee.CompanyId
      modelBuilder.Entity<Company>()
        .HasMany(company => company.Employees)
        .WithRequired(employee => employee.Company)
        .HasForeignKey(employee => employee.CompanyId);
    }
  }

  /// <summary>
  /// Initialize the database for <seealso cref="MSSQLContext"/> context.
  /// </summary>
  class ContextInitializer : CreateDatabaseIfNotExists<MSSQLContext>
  {
    protected override void Seed(MSSQLContext context)
    {
      var companyList = new List<Company>() 
      { 
        new Company()
        {
          Name = "Air Astana",
          TaxNumber = 7743013902,
          Address = "4A Zakarpatskaya street, Almaty 050039",
          Note = "Flag carrier airline",
          Employees = new List<Employee>()
          {
            new Employee() { FirstName = "Sveta", LastName = "Kairatova", IdentificationNumber = 211085001122 },
            new Employee() { FirstName = "Daniar", LastName = "Mukhametkaliov", IdentificationNumber = 211285009999 },
            new Employee() { FirstName = "Arman", LastName = "Nazerov", IdentificationNumber = 231085001342 },
          }
        },
        new Company() 
        { 
          Name = "Halyk Bank", 
          TaxNumber = 9943013902, 
          Address = "3 Berezovskiy St, Almaty 050060", 
          Note = "Commercial bank",
          Employees = new List<Employee>()
          {
            new Employee() { FirstName = "Damira", LastName = "Rustameva", IdentificationNumber = 261085001122 },
            new Employee() { FirstName = "Arman", LastName = "Camranev", IdentificationNumber = 231285009999 } 
          }
        },
        new Company() 
        { 
          Name = "KazTransOil", 
          TaxNumber = 1743013902, 
          Address = "Al-Farabi Avenue 71/27, Almaty 050000", 
          Note = "Oil transport",
          Employees = new List<Employee>()
          {
            new Employee() { FirstName = "Maria", LastName = "Assylhaneva", IdentificationNumber = 291085001122 }
          }
        },
        new Company() 
        { 
          Name = "KazakhGold", 
          TaxNumber = 640232103, 
          Address = "Rozybakiev Street 247А, Almaty 050060", 
          Note = "Gold mining" 
        },
        new Company() 
        { 
          Name = "Kaspi Bank", 
          TaxNumber = 793232103, 
          Address = "Arayly Ul. 16, Almaty 050045", 
          Note = "Commercial bank" 
        }
      };

      context.Companies.AddRange(companyList);
      context.SaveChanges();
    }
  }
}
