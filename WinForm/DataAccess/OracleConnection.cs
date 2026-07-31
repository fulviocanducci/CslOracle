using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

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
            //x.UseOracleSQLCompatibility(OracleSQLCompatibility.DatabaseVersion19);
        }).LogTo(x => Debug.Print(x), Microsoft.Extensions.Logging.LogLevel.Information);
    }

    public static OracleDataAccess Instance => new(Options.Options);
}
