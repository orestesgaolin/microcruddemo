using System;
using Microsoft.EntityFrameworkCore;
using MicroCrudDemo.Model;
namespace MicroCrudDemo.Context
{
    public class CrudContext : DbContext
    {
        public CrudContext
        (DbContextOptions<CrudContext> options)
            : base(options)
        { }

        public DbSet<Book> Books { get; set; }
    }
}
