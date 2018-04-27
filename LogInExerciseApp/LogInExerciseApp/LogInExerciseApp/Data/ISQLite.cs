using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogInExerciseApp.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
