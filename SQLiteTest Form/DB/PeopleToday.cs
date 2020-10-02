using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace SQLite3Test
{
    class PeopleToday
    {
        public string Path = "Data Source=D:/Desktop/SQLite/sqlite-tools-win32-x86-3330000/PeopleList.sqlite3";
        public long id { get; set; }
        public string name { get; set; }
        public string app { get; set; }
        public long date { get; set; }

        
    }
}
