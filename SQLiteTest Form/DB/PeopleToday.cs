using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace SQLite3Test
{
    class PeopleToday
    {
        public long id { get; set; }
        public string name { get; set; }
        public string app { get; set; }
        public string coordinate { get; set; }
        public long date { get; set; }
        public string place { get; set; }
    }
}