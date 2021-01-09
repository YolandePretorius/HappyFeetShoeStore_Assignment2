using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HappyFeetShoeStore.Data
{
    public class HappyFeetShoeStoreContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public HappyFeetShoeStoreContext() : base("name=HappyFeetShoeStoreContext")
        {
        }

        public System.Data.Entity.DbSet<HappyFeetShoeStore.Models.Category> Categories { get; set; }

        public System.Data.Entity.DbSet<HappyFeetShoeStore.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<HappyFeetShoeStore.Models.ProductImage> ProductImages { get; set; }
        public System.Data.Entity.DbSet<HappyFeetShoeStore.Models.ProductImageMapping> ProductImageMappings { get; set; }

        public System.Data.Entity.DbSet<HappyFeetShoeStore.ViewModel.EditUserViewModel> EditUserViewModels { get; set; }
    }
}
