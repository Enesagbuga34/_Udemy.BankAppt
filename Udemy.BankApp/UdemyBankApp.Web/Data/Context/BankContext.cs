using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyBankApp.Web.Data.Configurations;
using UdemyBankApp.Web.Data.Entities;

namespace UdemyBankApp.Web.Data.Context
{
    public class BankContext : DbContext
    {
        public  DbSet<Account> Accounts { get; set; }
        
        public  DbSet<ApplicationUser> ApplicationUsers { get; set; }


        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            base.OnModelCreating(modelBuilder);
        }

    }
}
