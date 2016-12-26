using System;
using System.Collections.Generic;
using System.Linq;
using MHG.Sample.Dependency.Model;
using SQLite.Net;
using Xamarin.Forms;

namespace MHG.Sample.Dependency.Helper
{
    public class SQLiteManager<T> : IDisposable where T : class
    {
        SQLiteConnection _sqLiteConnection;

        public SQLiteManager()
        {
            _sqLiteConnection = DependencyService.Get<ISqlLiteDependency>().GetConnection();
            _sqLiteConnection.CreateTable<T>();
        }

        #region CRUD

        public int Insert(params T[] s)
        {
            return _sqLiteConnection.InsertAll(s);
        }

        public int Update(params T[] s)
        {
            return _sqLiteConnection.UpdateAll(s);
        }

        public int Delete(int id)
        {
            return _sqLiteConnection.Delete<T>(id);
        }

        public int Delete(T s)
        {
            return _sqLiteConnection.Delete(s);
        }

        public int Delete(Func<T, bool> predicate)
        {
            var res = _sqLiteConnection.Table<T>().Where(predicate);
            res.Select(Delete);
            return res.Count();
        }

        public List<T> GetAll()
        {
            return _sqLiteConnection.Table<T>().ToList();
        }

        public List<T> GetAll(Func<T, bool> predicate)
        {
            return _sqLiteConnection.Table<T>().Where(predicate).ToList();
        }

        public List<T> GetAllOrderedAsc<K>(Func<T, K> predicate)
        {
            return _sqLiteConnection.Table<T>().OrderBy(predicate).ToList();
        }

        public List<T> GetAllOrderedDesc<K>(Func<T, K> predicate)
        {
            return _sqLiteConnection.Table<T>().OrderByDescending(predicate).ToList();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _sqLiteConnection.Table<T>().FirstOrDefault(predicate);
        }

        public T Get(int id)
        {
            return _sqLiteConnection.Get<T>(id);
        }
        #endregion

        public void Dispose()
        {
            _sqLiteConnection.Close();
            _sqLiteConnection.Dispose();
            _sqLiteConnection = null;
        }
    }
}
