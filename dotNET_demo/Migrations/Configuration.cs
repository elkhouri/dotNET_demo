namespace dotNET_demo.Migrations
{
    using dotNET_demo.Models;
    using Fluency;
    using Fluency.DataGeneration;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dotNET_demo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        public static class a
        {
            public static ProductBuilder Config
            {
                get { return new ProductBuilder(); }
            }
        }
        public class ProductBuilder : FluentBuilder< Product >
        {
            public ProductBuilder()
            {

            }

            public ProductBuilder ForProduct(string name)
            {
                SetProperty(x => x.Name, name);
                return this;
            }
        }
        protected override void Seed(dotNET_demo.Models.ApplicationDbContext context)
        {
            
            context.Products.AddOrUpdate(p => p.Name,
                new Product { Name = "TEST", Weight=5, Price=5, Size="1", Stock=false, Available_Date=DateTime.Now},
                a.Config.ForProduct("Product 1").build(),
                a.Config.ForProduct("Product 2").build(),
                a.Config.ForProduct("Product 3").build()
            );
        }
    }
}
