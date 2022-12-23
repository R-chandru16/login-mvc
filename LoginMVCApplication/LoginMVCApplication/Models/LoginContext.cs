using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginMVCApplication.Models
{
    public class LoginContext : DbContext
    {
        public
        LoginContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder
        modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(
            new Users()
            {
                EmailID = "demogmail.com",
                Password ="demo"
        
            },
            new
            Users()
            {
                EmailID = "chandru@gmail.com",
                Password = "chandru2598"
            }
            );
        }
    }
}
