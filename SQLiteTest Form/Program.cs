using SQLite3Test;
using SQLiteTest_Form.DB;
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

        static ConnectDB connectDB = new ConnectDB(Path);
        static PeopleToday today = new PeopleToday();
        static Command command = new Command(connectDB);
        static LibraryContext commandC = new LibraryContext();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            today.id = Command.Read<long>.ReadDB("Id")[0];
            today.name = Command.Read<string>.ReadDB("Name")[0];
            today.app = Command.Read<string>.ReadDB("App")[0];
            today.coordinate = Command.Read<string>.ReadDB("Coordinate")[2];
            today.date = Command.Read<long>.ReadDB("Date")[0];

            Application.Run(new Form1()
            {
                massege = $"{today.id} " +
                       $" {today.name} " +
                       $" {today.app} " +
                       $" {today.coordinate} " +
                       $" {today.date} \n"
            });
        }
    }
}
