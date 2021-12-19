
using FKDesignEntities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FKDesignDataAccess
{
    public class FKDesignDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-CCT1C3T; Database=FKDesignGeneric; uid=feridekrpnr46; pwd=12345");
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-CCT1C3T; Database=FKDesignDBGeneric; uid=feridekrpnr46; pwd=123");
        //}
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.ApplyConfiguration(new ProductConfiguration());
            //builder.ApplyConfiguration(new CategoryConfiguration());
            builder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }

        public FKDesignDBContext(DbContextOptions<FKDesignDBContext> options) : base(options)
        {
        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Faq> Faqs { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Role> Role { get; set; }
        

       
    }
   
}
