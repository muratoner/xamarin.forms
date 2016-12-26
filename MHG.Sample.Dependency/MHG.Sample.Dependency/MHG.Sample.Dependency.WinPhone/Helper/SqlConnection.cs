using System.IO;
using Windows.Storage;
using MHG.Sample.Dependency.Helper;
using MHG.Sample.Dependency.WinPhone.Helper;
using SQLite.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqlConnection))]
namespace MHG.Sample.Dependency.WinPhone.Helper
{
    public class SqlConnection : ISqlLiteDependency
    {
        public SQLiteConnection GetConnection()
    {
        var path = Path.Combine(ApplicationData.Current.LocalFolder.Path, Dependency.App.DbName);
        var platform = new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT();
        return new SQLiteConnection(platform, path);
    }
}
}
