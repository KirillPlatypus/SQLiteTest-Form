using SQLite3Test;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SQLiteTest_Form.Migration;

namespace SQLiteTest_Form.DB
{
    class Command
    {
        static Migrate1 migrate1;

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

                                column.Add((T)result[nameColumn]);

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


            public static List<PeopleToday> AnotherReadDB(PeopleToday today)
            {
                using (LibraryContext context = new LibraryContext())
                {
                    context.ChangeTracker.DetectChanges();

                    context.PeopleToday.Add(today);

                    try
                    {
                        context.SaveChanges();
                    }
                    catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
                    {
                       
                    }
                    catch(System.Data.Entity.Infrastructure.DbUpdateException) 
                    {
                        migrate1 = new Migrate1("place", ConnectDB);
                        migrate1.AddColumn();
                    }
                    return context.PeopleToday.ToList();
                }
                
            }
            
        }
        public static class Change<T>
        {
            public static void Update(long id, PeopleToday today, List<string> column)
            {
                using (var command = new SQLiteCommand($"UPDATE PeopleToday SET " +
                    $"{column[0]} = '{today.id}'," +
                    $"{column[1]} = '{today.name}', " +
                    $"{column[2]} = '{today.app}'," +
                    $"{column[3]} = '{today.date}'," +
                    $"{column[4]} = '{today.coordinate}' " +
                    $"WHERE Id = {id}; ", ConnectDB.connect))
                {

                    ConnectDB.OpenConnection();

                    var result = command.ExecuteReader();

                    ConnectDB.CloseConnection();
                }
            }

            public static void Insert(List<string> column, PeopleToday today)
            {
                using (var command = new SQLiteCommand($"INSERT INTO PeopleToday ({column[0]}, {column[1]}, {column[2]}, {column[3]}, {column[4]})" +
                    $" VALUES ('{today.id}', '{today.name}', '{today.app}', '{today.date}', '{today.coordinate}'); ", ConnectDB.connect))
                {

                    ConnectDB.OpenConnection();

                    var result = command.ExecuteReader();

                    ConnectDB.CloseConnection();
                }
            }

            public static void Delete(long id)
            {
                using (var command = new SQLiteCommand($"DELETE FROM PeopleToday WHERE Id = {id};", ConnectDB.connect))
                {
                    ConnectDB.OpenConnection();
                    
                    var result = command.ExecuteReader();

                    ConnectDB.CloseConnection();
                }
            }
        }
    }
}
