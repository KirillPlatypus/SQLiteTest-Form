using SQLite3Test;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest_Form.Migration
{
    public class Migrate1
    {
        string Column;
        ConnectDB ConnectDB;

        internal Migrate1(string column, ConnectDB connectDB)
        {
            Column = column;
            ConnectDB = connectDB;
        }

        public void AddColumn()
        {

            ConnectDB.OpenConnection();

            var commandALT = new SQLiteCommand($"ALTER TABLE PeopleToday ADD COLUMN {Column} text;", ConnectDB.connect);
            var resultALT = commandALT.ExecuteReader();

            ConnectDB.CloseConnection();

        }
    }
}
