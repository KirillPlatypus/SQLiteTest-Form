using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite.EF6;
using System.Data;
using System.IO;
using System.Data.SQLite;

namespace SQLite3Test
{
    class ConnectDB
    {
        public SQLiteConnection connect;

        public ConnectDB(string path)
        {
            connect = new SQLiteConnection(path);
            if (!File.Exists(path))
            {
                SQLiteConnection.CreateFile("PeopleList.sqlite3");
            }
        }

        public void OpenConnection()
        {
            if(connect.State != ConnectionState.Open)
            {
                connect.Open();
            }
        }
        public void CloseConnection()
        {
            if (connect.State != ConnectionState.Closed)
            {
                connect.Close();
            }
        }

    }
}
