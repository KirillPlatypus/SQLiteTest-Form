using SQLite3Test;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteTest_Form.DB
{
    class Command
    {
        static ConnectDB ConnectDB;

        public Command(ConnectDB connectDB)
        {
           ConnectDB = connectDB;
        }

        public static class Read<T>
        {
            static List<T> column = new List<T>();

            public static List<T> ReadDB(string nameColumn)
            {
                using (var command = new SQLiteCommand("SELECT * FROM PeopleToday", ConnectDB.connect))
                {

                    if (column.Count > 0)
                    {
                        column.Clear();
                    }

                    ConnectDB.OpenConnection();

                    var result = command.ExecuteReader();
                    if (result.HasRows)
                    {
                        for (int i = 0; result.Read(); i++)
                        {
                            try
                            {
                                if (result[nameColumn] != DBNull.Value)
                                {
                                    column.Add((T)result[nameColumn]);
                                }
                                else
                                {
                                    Change.ChangeDB(i, 200, nameColumn);
                                }
                            }
                            catch (System.IndexOutOfRangeException)
                            {
                                i--;
                                var commandALT = new SQLiteCommand($"ALTER TABLE PeopleToday\n ADD COLUMN {nameColumn} text;", ConnectDB.connect);
                                var resultALT = commandALT.ExecuteReader();

                            }
                        }
                    }
                    ConnectDB.CloseConnection();
                }
                return column;
            }


            //public void AnotherReadDB()
            //{
            //    using (LibraryContext context = new LibraryContext())
            //    {

            //        context.PeopleToday.Add(today[0]);

            //        today.id = context.PeopleToday.First().id;
            //        today.name = context.PeopleToday.First().name;
            //        today.app = context.PeopleToday.First().app;
            //        today.date = context.PeopleToday.First().date;
            //        try
            //        {
            //            context.SaveChanges();
            //        }
            //        catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
            //        {
            //            today.name = "Error";
            //        }
            //    }
            //}
        }
        public static class Change
        {
            public static void ChangeDB(long id, long number, string column)
            {
                using (var command = new SQLiteCommand($"UPDATE PeopleToday SET {column} = '{number}' WHERE Id = {id}; ", ConnectDB.connect))
                {

                    ConnectDB.OpenConnection();

                    //command.Parameters.AddWithValue("@Id", id);
                    //command.Parameters.AddWithValue("@Name", "Lara");
                    //command.Parameters.AddWithValue("@App", "DrakeHub");
                    //command.Parameters.AddWithValue($"@{column}", number.ToString());
                    //command.Parameters.AddWithValue("@Date", 900);

                    var result = command.ExecuteReader();

                    ConnectDB.CloseConnection();
                }
            }
        }
    }
}
