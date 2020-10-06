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
    public static class Program
    {
        static string Path = "Data Source=C:/Users/1/source/repos/SQLiteTest Form/SQLiteTest Form/bin/Debug/PeopleList1.db";

        static ConnectDB connectDB;
        static PeopleToday today = new PeopleToday();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            connectDB = new ConnectDB(Path);

            //ReadDB();

            using (LibraryContext context = new LibraryContext())
            {
                
                context.PeopleToday.Add(today);

                today.id = context.PeopleToday.First().id;
                today.name = context.PeopleToday.First().name;
                today.app = context.PeopleToday.First().app;
                today.date = context.PeopleToday.First().date;
                try
                {
                    context.SaveChanges();
                }
                catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
                {
                    today.name = "Error";
                }
            }
            Application.Run(new Form1(){ name = today.name });

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
                    today = new PeopleToday()
                    {
                        id = (long)result["Id"],
                        name = result["Name"].ToString(),
                        app = result["App"].ToString(),
                        date = (long)result["Date"]
                    };

                }
                
            }
            connectDB.CloseConnection();
        }

        private static void ChangeDB(long id, long number, string column)
        {
            var command = new SQLiteCommand($"INSERT INTO PeopleToday VALUES ", connectDB.connect);
            
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
