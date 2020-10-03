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
        public DbSet<PeopleToday> PeopleToday { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PeopleToday>().ToTable("PeopleToday");
        }
    }
}
