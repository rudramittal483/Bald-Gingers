using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //test to see that it exists
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void InStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AStock.InStock = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.InStock, TestData);
        }

        [TestMethod]
        public void DateAddedPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AStock.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DateAdded, TestData);
        }

        [TestMethod]
        public void LaptopIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property
            AStock.LaptopId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.LaptopId, TestData);
        }

        [TestMethod]
        public void ModelPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "Spectre x360";
            //assign the data to the property
            AStock.Model = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Model, TestData);
        }

        [TestMethod]
        public void BrandPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            string TestData = "HP";
            //assign the data to the property
            AStock.Brand = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Brand, TestData);
        }

        [TestMethod]
        public void PricepropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            double TestData = 1249.99;
            //assign the data to the property
            AStock.Price = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Price, TestData);

        }

    }
}