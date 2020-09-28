using System;
using System.Data.SQLite;


namespace SQLite3Test
{
    class Program
    {
        static PeopleToday today = new PeopleToday();
        static ConnectDB connectDB ;
        static void Main(string[] args)
        {
            connectDB = new ConnectDB(today.Path);

            connectDB.OpenConnection();

            ReadDB();
            ChangeDB(4, 700, "Date");
            ReadDB();

            connectDB.CloseConnection();
        }
        private static void ReadDB()
        {
            var command = new SQLiteCommand("SELECT * FROM PeopleToday", connectDB.connect);

            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    today = new PeopleToday()
                    {
                        id = (long)result["Id"],
                        name = result["Name"].ToString(),
                        app = result["App"].ToString(),
                        date = (long)result["Date"]
                    };
                    today.Message();

                }

            }
        }
        private static void ChangeDB(long id, long number, string column)
        {
            var command = new SQLiteCommand($"UPDATE PeopleToday SET {column} = '{number}' WHERE Id = {id}; ", connectDB.connect);
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", "Lara");
            command.Parameters.AddWithValue("@App", "DrakeHub");
            command.Parameters.AddWithValue("@Date", 900);
            
            command.ExecuteReader();
        }

    }
}
