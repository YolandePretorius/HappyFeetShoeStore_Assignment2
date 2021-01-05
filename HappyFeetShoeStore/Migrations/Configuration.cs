namespace HappyFeetShoeStore.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using HappyFeetShoeStore.Data;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<HappyFeetShoeStoreContext>
    {
        public Configuration()
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

            //var categories = new List<Category>
            //{
            //    new Category {Name = "Womans"},
            //    new Category {Name = "Mens"},
            //    new Category {Name = "Boys"},
            //    new Category {Name = "Girls"},
            //};

            //categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            //context.SaveChanges();

            //var products = new List<Product>
            //{
            //    new Product{Name = "Sandals", Description="Red leather sandals", Price=30.00M, CategoryID=categories.Single(c=> c.Name == "Womans").ID},
            //    new Product{Name = "Sandals", Description="Blue leather sandals",Price=30.00M, CategoryID=categories.Single(c=> c.Name == "Mens").ID},
            //    new Product{Name = "Sandals", Description="Pink leather sandals",Price=30.00M, CategoryID=categories.Single(c=> c.Name == "Girls").ID},
                
            //};

            //products.ForEach(c => context.Products.AddOrUpdate (p => p.Name, c));
            //context.SaveChanges();

        }
    }
}
