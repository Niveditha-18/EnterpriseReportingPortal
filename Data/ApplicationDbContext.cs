using Microsoft.EntityFrameworkCore;
using EnterpriseReportingPortal.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Report> Reports { get; set; }
    public DbSet<AcademicRecord> AcademicRecords { get; set; }
    public DbSet<FinancialRecord> FinancialRecords { get; set; }
}
