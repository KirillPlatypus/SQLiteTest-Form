using SQLite3Test;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SQLiteTest_Form.DB
{
    class Command
    {
        static ConnectDB ConnectDB;
        static PeopleToday todays = new PeopleToday();
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
                                    
                                    Change<PeopleToday>.Update(1, 0, nameColumn);
                                    Change<PeopleToday>.Update(2, 0, nameColumn);
                                    Change<PeopleToday>.Update(3, 0, nameColumn);
                                    Change<PeopleToday>.Update(4, 0, nameColumn);
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


            public static List<PeopleToday> AnotherReadDB(PeopleToday today)
            {
                using (LibraryContext context = new LibraryContext())
                {

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
                        ConnectDB.OpenConnection();

                        var commandALT = new SQLiteCommand($"ALTER TABLE PeopleToday\n ADD COLUMN coordinate text;", ConnectDB.connect);
                        var resultALT = commandALT.ExecuteReader();
                        ConnectDB.CloseConnection();

                    }
                    return context.PeopleToday.ToList();
                }
                
            }
            
        }
        public static class Change<T>
        {
            public static void Update(long id, long number, string column)
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

                    //ConnectDB.CloseConnection();
                }
            }
            public static void Insert(string column, PeopleToday today)
            {
                using (var command = new SQLiteCommand($"INSERT INTO PeopleToday ({column}) VALUES ('{today.id}, {today.name}, " +
                    $"{today.app}, {today.date}, {today.coordinate}'); ", ConnectDB.connect))
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
