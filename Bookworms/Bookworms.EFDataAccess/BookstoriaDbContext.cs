using Bookworms.AplicationLogic.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bookworms.EFDataAccess
{
    public class BookwormsDbContext : DbContext
    {
        public BookwormsDbContext(DbContextOptions<BookwormsDbContext> options): base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
