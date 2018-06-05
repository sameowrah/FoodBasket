using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
namespace FoodBasket.Models
{
   public class CartContext : DbContext //enable-migrations -contexttypename CartContext

    { //code to generate DBSet for each entity set
        public DbSet<Register> Users { get; set; }
        public DbSet<Item> Item { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Login> Login { get; set; }    
        public DbSet<MenuCategory> MenuCategories { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        protected override void OnModelCreating(DbModelBuilder modelBuilder) // Removes statement in the OnModelCreating method 2 prevent table names from being pluralized
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 
        }
    }
}