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
        static PeopleToday today = new PeopleToday();
        static ConnectDB connectDB;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            connectDB = new ConnectDB(today.Path);

            connectDB.OpenConnection();

            using (LibraryContext context = new LibraryContext())
            {
                today.id = 5;
                today.name = "Georg";
                today.app = "Georges";
                today.date = 2100;

                context.peopleTodays.Add(today);
                context.SaveChanges();
            }
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
