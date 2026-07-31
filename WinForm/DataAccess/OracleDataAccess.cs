using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WinForm.Models;
using WinForm.Models.Configurations;

namespace WinForm.DataAccess;

public sealed class OracleDataAccess : DbContext
{
    public OracleDataAccess()
    {
    }

    public OracleDataAccess(DbContextOptions options) : base(options)
    {
    }

    public DbSet<People> People { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Assembly? configuration = Assembly.GetAssembly(typeof(PeopleConfiguration));
        if (configuration != null)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(configuration);
        }
        base.OnModelCreating(modelBuilder);
    }
}
