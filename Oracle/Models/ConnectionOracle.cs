using Microsoft.EntityFrameworkCore;
using Oracle.DatabaseAccess;

namespace Oracle.Models
{
    public static class ConnectionOracle
    {
        internal static DbContextOptionsBuilder<Context> Options { get; set; }
        internal static string Value => "User Id=system;Password=oracle123;Data Source=192.168.2.115:1521/FREEPDB1;";
        static ConnectionOracle()
        {
            Options = new DbContextOptionsBuilder<Context>();
            Options.UseOracle(Value, x =>
            {

            }).LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

        public static Context Create()
        {
            return new Context(Options.Options);
        }
    }
}
