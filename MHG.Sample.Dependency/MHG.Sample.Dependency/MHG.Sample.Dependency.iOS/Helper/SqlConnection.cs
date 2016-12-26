using System;
using System.IO;
using MHG.Sample.Dependency.Helper;
using MHG.Sample.Dependency.iOS.Helper;
using SQLite.Net;
using Xamarin.Forms;

[assembly: Dependency(typeof(SqlConnection))]
namespace MHG.Sample.Dependency.iOS.Helper
{
    public class SqlConnection : ISqlLiteDependency
    {
        public SQLiteConnection GetConnection()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path = Path.Combine(path, App.DbName);
            var platform = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
            return new SQLiteConnection(platform, path);
        }
    }
}