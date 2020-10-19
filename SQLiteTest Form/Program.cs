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

            Application.Run(new Form1()
            
            );
        }
    }
}
