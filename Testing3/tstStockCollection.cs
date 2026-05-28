using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary;
using System.Collections.Generic;


namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //test to see that it exists
            Assert.IsNotNull(AllStocks);
        }


        [TestMethod]
        public void StockListOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects with the same properties as clsStock
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.LaptopId = 4;
            TestItem.Model = "Spectre x360";
            TestItem.Brand = "HP";
            TestItem.Price = 1249.99;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DiscountId = 1;
            TestItem.Quantity = 25;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.StockList, TestList);
        }

        [TestMethod]
        public void ThisStockPropertyOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.LaptopId = 4;
            TestStock.Model = "Spectre x360";
            TestStock.Brand = "HP";
            TestStock.Price = 1249.99;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.DiscountId = 1;
            TestStock.Quantity = 25;
            //assign the data to the property
            AllStocks.ThisStock = TestStock;
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects with the same properties as clsStock
            List<clsStock> TestList = new List<clsStock>();
            //add an item to the list
            //create the item of test data
            clsStock TestItem = new clsStock();
            //set its properties
            TestItem.InStock = true;
            TestItem.LaptopId = 4;
            TestItem.Model = "Spectre x360";
            TestItem.Brand = "HP";
            TestItem.Price = 1249.99;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.DiscountId = 1;
            TestItem.Quantity = 25;
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStocks.StockList = TestList;
            //test to see that the count is correct
            Assert.AreEqual(AllStocks.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.LaptopId = 9;
            TestStock.Model = "MacBook Pro 16";
            TestStock.Brand = "Apple";
            TestStock.Price = 2999.99;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.DiscountId = 0;
            TestStock.Quantity = 25;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestStock;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestStock.LaptopId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.Model = "MacBook Pro 16";
            TestStock.Brand = "Apple";
            TestStock.Price = 2999.99;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.DiscountId = 0;
            TestStock.Quantity = 25;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestStock;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestStock.LaptopId = PrimaryKey;
            //modify the test data
            TestStock.InStock = false;
            TestStock.Model = "MacBook Pro 16";
            TestStock.Brand = "Apple";
            TestStock.Price = 2499.99;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.DiscountId = 0;
            TestStock.Quantity = 0;
            //set the record based on the new test data
            AllStocks.ThisStock = TestStock;
            //update the record
            AllStocks.Update();
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.ThisStock, TestStock);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsStockCollection AllStocks = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestStock.InStock = true;
            TestStock.LaptopId = 16;
            TestStock.Model = "MacBook Air";
            TestStock.Brand = "Apple";
            TestStock.Price = 1499.99;
            TestStock.DateAdded = DateTime.Now.Date;
            TestStock.DiscountId = 0;
            TestStock.Quantity = 25;
            //set ThisStock to the test data
            AllStocks.ThisStock = TestStock;
            //add the record
            PrimaryKey = AllStocks.Add();
            //set the primary key of the test data
            TestStock.LaptopId = PrimaryKey;
            //find the record
            AllStocks.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStocks.Delete();
            //now find the record again
            Boolean Found = AllStocks.ThisStock.Find(PrimaryKey);
            //test to see that it was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByBrandMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsStockCollection AllStocks = new clsStockCollection();
            //create an instance of the class containing filtered results
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a blank string (should return all records)
            FilteredStocks.ReportByBrand("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStocks.Count, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByBrandNoneFound()
        {
            //create an instance of the class containing filtered results
            clsStockCollection FilteredStocks = new clsStockCollection();
            //apply a brand that doesn't exist
            FilteredStocks.ReportByBrand("xxxxx");
            //test to see that there are no records returned
            Assert.AreEqual(0, FilteredStocks.Count);
        }

        [TestMethod]
        public void ReportByBrandTestDataFound()
        {
            //create an instance of the class containing filtered results
            clsStockCollection FilteredStocks = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;

            //apply a brand you know exists in the database
            FilteredStocks.ReportByBrand("Lenovo");

            //check that the correct number of records are found (should now be 2!)
            if (FilteredStocks.Count == 2)
            {
                //check that the first record is ID 1
                if (FilteredStocks.StockList[0].LaptopId != 1)
                {
                    OK = false;
                }
                //check that the second record is ID 6
                if (FilteredStocks.StockList[1].LaptopId != 6)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that the outcome is true
            Assert.IsTrue(OK);
        }
    }
}