using System.IO;
using MHG.Sample.Dependency.Droid.Helper;
using MHG.Sample.Dependency.Helper;
using SQLite.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqlConnection))]
namespace MHG.Sample.Dependency.Droid.Helper
{
    public class SqlConnection : ISqlLiteDependency
    {
        public SQLiteConnection GetConnection()
        {
            var folder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(folder, App.DbName);
            var android = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            return new SQLiteConnection(android, path);
        }
    }
}