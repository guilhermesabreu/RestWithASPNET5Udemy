using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Model.Context
{
    public class SQLContext : DbContext
    {
        public SQLContext()
        {

        }

        public SQLContext(DbContextOptions<SQLContext> options) : base(options) { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
