using Microsoft.EntityFrameworkCore;
using Oracle.Models;
using Oracle.Models.Configurations;
using System.Reflection;

namespace Oracle.DatabaseAccess
{
    public sealed class Context : DbContext
    {
        public Context() { }
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Sources> Sources { get; set; }
        public DbSet<Controls> Controls { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Assembly? assemblyConfigurations = Assembly.GetAssembly(typeof(PeopleConfiguration));
            if (assemblyConfigurations != null)
            {
                modelBuilder.ApplyConfigurationsFromAssembly(assemblyConfigurations);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
