using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class DataContext: DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Loan> loans { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<UserRole> roles { get; set; }
        public DbSet<BookItem> book_items { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().ToTable(nameof(Book));
            modelBuilder.Entity<Author>().ToTable(nameof(Author));
            modelBuilder.Entity<Category>().ToTable(nameof(Category));
            modelBuilder.Entity<Loan>().ToTable(nameof(Loan));
            modelBuilder.Entity<User>().ToTable(nameof(User));
            modelBuilder.Entity<UserRole>().ToTable(nameof(UserRole));
            modelBuilder.Entity<BookItem>().ToTable(nameof(BookItem));

            base.OnModelCreating(modelBuilder);
        }
    }
}
