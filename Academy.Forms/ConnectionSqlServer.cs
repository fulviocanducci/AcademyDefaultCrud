using System;
using System.Data.SqlClient;

namespace Academy.Forms
{
    public class ConnectionSqlServer
    {
        private ConnectionSqlServer() { }

        public const string ConnectionString = "Server=192.168.2.65,1433;Database=Academy;User Id=sa;Password=770301Ab@;TrustServerCertificate=True;";
        private static Lazy<SqlConnection> LazySqlConnection => new Lazy<SqlConnection>(() => new SqlConnection(ConnectionString));
        public static SqlConnection Instance => LazySqlConnection.Value;
    }

    //public sealed class Singleton
    //{
    //    private static readonly Lazy<Singleton> _lazyInstance =
    //        new Lazy<Singleton>(() => new Singleton());

    //    // 2. Make the constructor private so no other code can use 'new Singleton()'
    //    private Singleton()
    //    {
    //    }

    //    // 3. Expose a public property to access the single instance
    //    public static Singleton Instance => _lazyInstance.Value;

    //    // Example instance method
    //    public void DoSomething()
    //    {
    //        Console.WriteLine("Singleton instance is working!");
    //    }
    //}
}
