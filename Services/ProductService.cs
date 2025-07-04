﻿using CacheLoggerAppAPI.Models;

namespace CacheLoggerAppAPI.Services
{
    public class ProductService
    {
        public Product GetProductById(int id)
        {
            Thread.Sleep(1000);
            return new Product { Id = id, Name= $"Product {id}", Price =id * 10 };
        }

        public List<Product> GetAllProducts()
        {
            Thread.Sleep(1000);
            return Enumerable.Range(2,10).Select(id => new Product
            {
                Id = id,
                Name = $"Product {id}",
                Price = id * 10
            }).ToList();
        }

    }
}
