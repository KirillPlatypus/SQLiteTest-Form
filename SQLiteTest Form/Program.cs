using SQLite3Test;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SQLiteTest_Form
{
    static class Program
    {
        static string Path = "Data Source=D:/Desktop/SQLite/sqlite-tools-win32-x86-3330000/PeopleList.sqlite3";

        static ConnectDB connectDB;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            connectDB = new ConnectDB(Path);

           // ReadDB();

            using (LibraryContext context = new LibraryContext())
            {
                PeopleToday today = new PeopleToday();

                today.app = "intelligentsiaOnline";
                today.name = "Victoria";
                today.id = 5;
                today.date = 2000;

                context.peopleTodays.Add(today);
                context.SaveChanges();
            }
        }
        private static void ReadDB()
        {
            var command = new SQLiteCommand("SELECT * FROM PeopleToday", connectDB.connect);

            connectDB.OpenConnection();
            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                while (result.Read())
                {
                    //today = new PeopleToday()
                    //{
                    //    id = (long)result["Id"],
                    //    name = result["Name"].ToString(),
                    //    app = result["App"].ToString(),
                    //    date = (long)result["Date"]
                    //};

                }
                
            }
            connectDB.CloseConnection();
        }

        private static void ChangeDB(long id, long number, string column)
        {
            var command = new SQLiteCommand($"UPDATE PeopleToday SET {column} = '{number}' WHERE Id = {id}; ", connectDB.connect);
            
            connectDB.OpenConnection();
            
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", "Lara");
            command.Parameters.AddWithValue("@App", "DrakeHub");
            command.Parameters.AddWithValue("@Date", 900);

            command.ExecuteReader();
            connectDB.CloseConnection();
        }
    }
}
