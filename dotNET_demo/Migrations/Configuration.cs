namespace dotNET_demo.Migrations
{
    using dotNET_demo.Models;
    using Fluency;
    using Fluency.DataGeneration;
    using NLipsum;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<dotNET_demo.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
        public static class a
        {
            public class ProductBuilder : FluentBuilder<Product>
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
            public class NewsBuilder : FluentBuilder<News>
            {
                public NewsBuilder()
                {
                    SetProperty(x => x.TimeStamp, DateTime.Now);
                    SetProperty(x => x.Content, NLipsum.Core.LipsumGenerator.Generate(1));
                }

                public NewsBuilder ForNews(string s)
                {
                    SetProperty(x => x.Title, s);
                    return this;
                }
            }
            public static ProductBuilder Product
            {
                get { return new ProductBuilder(); }
            }
            public static NewsBuilder News
            {
                get { return new NewsBuilder(); }
            }
        }

        protected override void Seed(dotNET_demo.Models.ApplicationDbContext context)
        {
            context.Products.AddOrUpdate(p => p.Name,
                a.Product.ForProduct("Product 1").build(),
                a.Product.ForProduct("Product 2").build(),
                a.Product.ForProduct("Product 3").build()
            );
            context.News.AddOrUpdate(p => p.Title,
                a.News.ForNews("News 1").build(),
                a.News.ForNews("News 2").build(),
                a.News.ForNews("News 3").build()
            );
        }
    }
}
