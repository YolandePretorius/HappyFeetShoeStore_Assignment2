namespace HappyFeetShoeStore.Migrations
{
    using HappyFeetShoeStore.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HappyFeetShoeStore.ShoeStoreContent.StoreContent>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HappyFeetShoeStore.ShoeStoreContent.StoreContent context)
        {
            var categories = new List<Category>
            {
                new Category {Name = "Womans shoes"},
                new Category {Name = "Mens Shoes"},
                new Category {Name = "Boys Shoes"},
                new Category {Name = "Girls Shoes"},

            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{Name = "Sandals", Description="Red leather sandals"},
                new Product{Name = "Sandals", Description="Red leather sandals"},
                 new Product{Name = "Sandals", Description="Red leather sandals"},
            };

        }
    }
}
