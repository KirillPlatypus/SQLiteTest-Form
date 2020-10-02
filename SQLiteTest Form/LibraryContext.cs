using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace SQLite3Test
{
    class LibraryContext : DbContext
    {
        public LibraryContext() : base("name=LibraryContext")
        {

        }
        public DbSet<PeopleToday> peopleTodays { get; set; }
    }
}
