﻿using DataAccess.Abstract;
using Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product { ProductId = 1, CategoryId = 1, ProductName = "Bardak", UnitePrice = 15, UnitsInStock = 15 },
            new Product { ProductId = 2, CategoryId = 1, ProductName = "Kamera", UnitePrice = 500, UnitsInStock = 3},
            new Product { ProductId = 3, CategoryId = 2, ProductName = "Telefon", UnitePrice = 1500, UnitsInStock = 2 },
            new Product { ProductId = 4, CategoryId = 2, ProductName = "Klavye", UnitePrice = 150, UnitsInStock = 65},
            new Product { ProductId = 5, CategoryId = 2, ProductName = "Fare", UnitePrice = 85, UnitsInStock = 1 }
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
            
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitePrice = product.UnitePrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
