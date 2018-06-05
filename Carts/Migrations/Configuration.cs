namespace FoodBasket.Migrations
{
    using FoodBasket.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Diagnostics;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FoodBasket.Models.CartContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FoodBasket.Models.CartContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            var employees = new List<Employee>
            {
                new Employee {Emp_ID = 101, FName = "Zoro", LName = "Roronoa",  Email = "roronoazoro@gmail.com" },
                new Employee {Emp_ID = 102, FName = "Luffy", LName = "D", Email = "monkeydluffy@gmail.com"},
                new Employee {Emp_ID = 103, FName = "Yixing",   LName = "Zhang", Email = "zhangyixing@gmail.com"}
            };
            employees.ForEach(s => context.Employees.AddOrUpdate(p => p.LName, s));
            context.SaveChanges();


            var menuItem = new List<MenuItem>
            {
                new MenuItem {MenuItemID = 01, MenuCatID = 201, Name = "Salad", Description = "Traditional Greek salad.", Price = 30.00, Quantity = 5, Order_ID = 1},
                new MenuItem {MenuItemID = 02, MenuCatID = 202, Name = "Bread", Description = "Freshly baked bread.", Price = 15.00, Quantity = 5, Order_ID = 2 },
                new MenuItem {MenuItemID = 03, MenuCatID = 203, Name = "Chicken", Description = "Scrumptious oven-baked portugese chicken.", Price = 50.00, Quantity = 10, Order_ID = 3},

            };
            menuItem.ForEach(s => context.MenuItems.AddOrUpdate(p => p.MenuItemID, s));
            context.SaveChanges();

            var menuCategory = new List<MenuCategory>
            {
                new MenuCategory {MenuCatID = 201, Cat_Name = "Starters", Order_ID = 1},
                new MenuCategory {MenuCatID = 202, Cat_Name = "Dessert & Bakery", Order_ID = 2},
                new MenuCategory {MenuCatID = 203, Cat_Name = "Main Meal", Order_ID = 3}

            };
            menuCategory.ForEach(s => context.MenuCategories.AddOrUpdate(p => p.MenuCatID, s));
            context.SaveChanges();


          /*  var order = new List<Order>
            {
                new Order {Order_ID = 201, Emp_ID = "101", MenuItemID = 01}, Item_Price = 30.00, Order_Quantity = 1, Item_TotalPrice = 30.00},
                new Order {Order_ID = 201, Emp_ID = "101", MenuItemID = 01 }, Item_Price = 30.00, Order_Quantity = 1, Item_TotalPrice = 30.00},
                new Order {Order_ID = 201, Emp_ID = "101", MenuItemID = 01}, Item_Price = 30.00, Order_Quantity = 1, Item_TotalPrice = 30.00}
            };
            order.ForEach(s => context.Orders.AddOrUpdate(p => p.Order_ID, s));
            context.SaveChanges();*/
            

        }
    }

}
//add migration update-database

