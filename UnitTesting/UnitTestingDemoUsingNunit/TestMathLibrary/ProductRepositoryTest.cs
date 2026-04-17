using System;
using System.Collections.Generic;
using System.Text;
using NUnit;
using NUnit.Framework.Legacy;
using MathLibrary;
namespace TestMathLibrary
{
    internal class ProductRepositoryTest
    {
        [Test]
        public void Test_Details()
        {
            //Arrange
            ProductRepository repository = new ProductRepository();
            int id = 1;
            //Act
            var product = repository.Details(1);
            
            //Arrange
            Assert.That(product, Is.Not.Null);
            Assert.That(id,Is.EqualTo(product.Id));
        }
        [Test]
        public void Test_GetAll()
        {
            //Arrange
            ProductRepository repository = new ProductRepository();
            //Act
            var products = repository.GetProducts();
            //Arrange
            //Assert.That(products, Is.Not.Null);
            Assert.That(products.Count, Is.GreaterThan(0));
        }
    }
}
