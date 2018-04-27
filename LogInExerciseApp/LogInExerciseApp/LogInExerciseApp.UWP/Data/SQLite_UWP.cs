using LogInExerciseApp.Data;
using LogInExerciseApp.UWP.Data;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQLite_UWP))]

namespace LogInExerciseApp.UWP.Data
{
    public class SQLite_UWP : ISQLite
    {
        public SQLite_UWP() { }

        public SQLiteConnection GetConnection()
        {
            var dbName = "TestDb.db3";
            string documentsPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentsPath, dbName);
            var connection = new SQLite.SQLiteConnection(path);

            return connection;
        }
    }
}
