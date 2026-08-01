using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace WinForm.DataAccess;

public sealed class OracleConnection
{
    public DbContextOptions<OracleDataAccess> Options { get; }

    private const string ConnectionString =
        "User Id=system;" +
        "Password=oracle123;" +
        "Data Source=192.168.2.115:1521/FREEPDB1;";

    private OracleConnection()
    {
        Options = new DbContextOptionsBuilder<OracleDataAccess>()
            .UseOracle(ConnectionString)
            .LogTo(
                message => Debug.Print(message),
                LogLevel.Information)
            .Options;
    }

    private static readonly Lazy<OracleConnection> Lazy = new(() => new OracleConnection());
    public static OracleConnection Instance => Lazy.Value;
    public OracleDataAccess CreateContext()
    {
        return new OracleDataAccess(Options);
    }
}