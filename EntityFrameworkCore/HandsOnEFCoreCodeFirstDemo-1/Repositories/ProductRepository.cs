using HandsOnEFCoreCodeFirstDemo_1.DataBase;
using HandsOnEFCoreCodeFirstDemo_1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandsOnEFCoreCodeFirstDemo_1.Repositories
{
    internal class ProductRepository
    {
        private readonly DataBase.AppContext appContext;
        public ProductRepository()
        {
            appContext = new DataBase.AppContext();
        }
        public void AddProduct(Product product)
        {
            try
            {
                appContext.Products.Add(product);
                appContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Product> GetProducts()
        {
            try
            {
                return appContext.Products.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public Product? GetProduct(int productId)
        {
            var product=appContext.Products.Find(productId); //Find method is used to search record using primary key value
            return product;
        }
        public Product? GetProductByName(string productName)
        {
            var product = appContext.Products.SingleOrDefault
                (p => p.Name == productName);
            return product;
        }
        //Delete Product
        public void DeleteProduct(Product product)
        {
            appContext.Products.Remove(product);
            appContext.SaveChanges();
        }
        public void DeleteProductUsingId(int productId)
        {
            var product= appContext.Products.SingleOrDefault(p => p.Id == productId);
            appContext.Products.Remove(product);
            appContext.SaveChanges();
        }
        //Edit Product
        public void EditProduct(Product product) //here product object contain updated object details
        {
            appContext.Products.Update(product);
            appContext.SaveChanges();
        }
    }
}
