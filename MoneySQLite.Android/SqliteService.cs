using System;
using Xamarin.Forms;
using MoneySQLite.Droid;
using System.IO;
using MoneySQLite;

[assembly: Dependency(typeof(SqliteService))]
namespace MoneySQLite.Droid
{
    public class SqliteService : INterfaceConnection
    {
        public SqliteService() { }
        public SQLite.Net.SQLiteConnection GetConnection()
        {
            var sqliteFilename = "MoneyManager.db3";
            string documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, sqliteFilename);

            Console.WriteLine(path);
            if (!File.Exists(path)) File.Create(path);
            var plat = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
            var conn = new SQLite.Net.SQLiteConnection(plat, path);
            return conn;
        }
    }
}