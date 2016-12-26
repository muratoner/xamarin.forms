namespace MHG.Sample.Dependency.Helper
{
    public interface ISqlLiteDependency
    {
        SQLite.Net.SQLiteConnection GetConnection();
    }
}

