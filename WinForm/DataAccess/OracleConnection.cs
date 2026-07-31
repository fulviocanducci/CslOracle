using Microsoft.EntityFrameworkCore;

namespace WinForm.DataAccess;

public static class OracleConnection
{
    internal static DbContextOptionsBuilder<OracleDataAccess> Options { get; set; }
    internal static string Value => "User Id=system;Password=oracle123;Data Source=192.168.2.115:1521/FREEPDB1;";
    static OracleConnection()
    {
        Options = new DbContextOptionsBuilder<OracleDataAccess>();
        Options.UseOracle(Value, x =>
        {

        });//.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
    }

    public static OracleDataAccess Instance => new(Options.Options);
}
