using Catalog.API.Entities;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            var existsProduct = productCollection.Find(p => true).Any();

            if (!existsProduct)
                productCollection.InsertManyAsync(GetMyProducts());
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f5",
                    Name = "IPhone X",
                    Description = "Lorem Ipsum dolor",
                    Image = "product-1.png",
                    Price = 950.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Id = "602d2149e773f2a3990b47f6",
                    Name = "Samsung S10",
                    Description = "Lorem Ipsum dolor",
                    Image = "product-2.png",
                    Price = 840.00M,
                    Category = "Smartphone"
                },
            };
        }
    }
}
