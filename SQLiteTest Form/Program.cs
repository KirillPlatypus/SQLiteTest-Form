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
        static Command<string> command = new Command<string>(connectDB);
        static Command<long> commandInt = new Command<long>(connectDB);

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            today.id = commandInt.ReadDB("Id")[0];
            today.name = command.ReadDB("Name")[0];
            today.app = command.ReadDB("App")[1];
            today.date = commandInt.ReadDB("Date")[0];

            Application.Run(new Form1()
            {
                name = $"{today.id} " +
                       $"{today.name} " +
                       $"{today.app} " +
                       $"{today.date} "
            });
        }
    }
}
