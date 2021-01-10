namespace HappyFeetShoeStore.Migrations.StoreConfiguration
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HappyFeetShoeStore.Data;
    using Models;

    internal sealed class StoreConfiguration : DbMigrationsConfiguration<HappyFeetShoeStoreContext>
    {
        public StoreConfiguration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HappyFeetShoeStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var categories = new List<Category>
            {
                new Category {Name = "Womans"},
                new Category {Name = "Mens"},
                new Category {Name = "Boys"},
                new Category {Name = "Girls"},
            };

            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Name = "Boots", Description="green leather Boots", Price=30.00M, CategoryID=categories.Single(c=> c.Name == "Womans").ID},
                new Product{Name = "Sandals", Description="yellow leather sandals",Price=30.00M, CategoryID=categories.Single(c=> c.Name == "Mens").ID},
                new Product{Name = "Golf Shoes", Description="Pink leather Golf Shoes",Price=30.00M, CategoryID=categories.Single(c=> c.Name == "Girls").ID},

            };

            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var orders = new List<Order>
             {
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                 Town="Town1", County="County", Postcode="PostCode" }, TotalPrice=4.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 1) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                 Town="Town1", County="County", Postcode="PostCode" }, TotalPrice=2.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 2) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                 Town="Town1", County="County", Postcode="PostCode" }, TotalPrice=1.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 3) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                 Town="Town1", County="County", Postcode="PostCode" }, TotalPrice=24.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 4) ,
                 DeliveryName="Admin" },
                 new Order { DeliveryAddress = new Address { AddressLine1="1 Some Street",
                 Town="Town1", County="County", Postcode="PostCode" }, TotalPrice=8.99M,
                 UserID="admin@example.com", DateCreated=new DateTime(2014, 1, 5) ,
                 DeliveryName="Admin" }
             };

            orders.ForEach(c => context.Orders.AddOrUpdate(o => o.DateCreated, c));
            context.SaveChanges();
            var orderLines = new List<OrderLine>
             {
                     //new OrderLine { OrderID = 1, ProductID = products.Single( c=> c.Name == "Boots").ID, ProductName="Boots", Quantity=1, UnitPrice=products.Single( c=> c.Name == "Boots").Price },
                     //new OrderLine { OrderID = 2, ProductID = products.Single( c=> c.Name == "Sandals").ID, ProductName="Sandals", Quantity=1, UnitPrice=products.Single( c=> c.Name =="Sandals").Price },
                     new OrderLine { OrderID = 3, ProductID = products.Single( c=> c.Name == "Golf Shoes").ID, ProductName="Golf Shoes", Quantity=1, UnitPrice= products.Single( c=> c.Name == "Golf Shoes").Price }

             };
            orderLines.ForEach(c => context.OrderLines.AddOrUpdate(ol => ol.OrderID, c));
            context.SaveChanges();
        }


    


    }
}
