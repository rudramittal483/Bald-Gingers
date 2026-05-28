using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        //good test data
        //create some test data to pass to the method
        string Model = "Spectre x360";
        string Brand = "HP";
        string Price = 1249.99.ToString();
        string DateAdded = DateTime.Now.Date.ToString();
        string DiscountId = 1.ToString();
        string Quantity = 25.ToString();


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

        [TestMethod]
        public void DiscountIdPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AStock.DiscountId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.DiscountId, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //create some test data to assign to the property
            Int32 TestData = 10;
            //assign the data to the property
            AStock.Quantity = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //test to see that the result is correct
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestLaptopIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the laptop id
            if (AStock.LaptopId != 4)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestModelFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the model
            if (AStock.Model != "Spectre x360")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);


        }

        [TestMethod]
        public void DateAddedFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the date added
            if (AStock.DateAdded != Convert.ToDateTime("10-02-2024"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void InStockFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the in stock
            if (AStock.InStock != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void PriceFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the price
            if (AStock.Price != 1249.99)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void BrandFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the brand
            if (AStock.Brand != "HP")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void DiscountIdFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the discount id
            if (AStock.DiscountId != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void QuantityFound()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 LaptopId = 4;
            //invoke the method
            Found = AStock.Find(LaptopId);
            //check the quantity
            if (AStock.Quantity != 25)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //boolean variable to store the results of the validation
            Boolean OK = true;
            //invoke the method
            String Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the date variable to a non date value
            string DateAdded = "this is not a date!";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the price variable to a non numeric value
            string Price = "this is not a price!";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the model variable to a string that is too long
            string Model = "";
            Model = Model.PadRight(101, 'a');
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the brand variable to a string that is too long
            string Brand = "";
            Brand = Brand.PadRight(101, 'a');
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the price variable to a negative value
            string Price = "-1";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void ModelInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the model variable to an empty string
            string Model = "";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the brand variable to an empty string
            string Brand = "";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the model variable to a string that is too short
            string Model = "";
            Model = Model.PadRight(0, 'a');
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinMinusOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the brand variable to a string that is too short
            string Brand = "";
            Brand = Brand.PadRight(0, 'a');
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountIdMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the discount id variable to a value less than the minimum
            string DiscountId = "-1";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the quantity variable to a value less than the minimum
            string Quantity = "-1";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the quantity variable to a non numeric value
            string Quantity = "this is not a quantity!";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountIdInvalidData()
        {
            //create an instance of the class we want to create
            clsStock AStock = new clsStock();
            //string variable to store any error message
            String Error = "";
            //set the discount id variable to a non numeric value
            string DiscountId = "this is not a discount id!";
            //invoke the method
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, Quantity);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ModelMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 1 character
            string TestModel = "a";
            Error = AStock.Valid(TestModel, Brand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 2 characters
            string TestModel = "ab";
            Error = AStock.Valid(TestModel, Brand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 99 characters
            string TestModel = "".PadRight(99, 'a');
            Error = AStock.Valid(TestModel, Brand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ModelMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 100 characters
            string TestModel = "".PadRight(100, 'a');
            Error = AStock.Valid(TestModel, Brand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 1 character
            string TestBrand = "H";
            Error = AStock.Valid(Model, TestBrand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 2 characters
            string TestBrand = "HP";
            Error = AStock.Valid(Model, TestBrand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMaxMinusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 99 characters
            string TestBrand = "".PadRight(99, 'a');
            Error = AStock.Valid(Model, TestBrand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BrandMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            // 100 characters
            string TestBrand = "".PadRight(100, 'a');
            Error = AStock.Valid(Model, TestBrand, Price, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestPrice = "-1000.00";
            Error = AStock.Valid(Model, Brand, TestPrice, DateAdded, DiscountId, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestPrice = "0.00";
            Error = AStock.Valid(Model, Brand, TestPrice, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestPrice = "1.00";
            Error = AStock.Valid(Model, Brand, TestPrice, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestPrice = "99999.99";
            Error = AStock.Valid(Model, Brand, TestPrice, DateAdded, DiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestQuantity = "-500";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, TestQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestQuantity = "0";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, TestQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestQuantity = "1";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, TestQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestQuantity = "10000";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, DiscountId, TestQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountIdExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestDiscountId = "-100";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, TestDiscountId, Quantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountIdMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestDiscountId = "0";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, TestDiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountIdMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestDiscountId = "1";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, TestDiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountIdExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string TestDiscountId = "999";
            Error = AStock.Valid(Model, Brand, Price, DateAdded, TestDiscountId, Quantity);
            Assert.AreEqual(Error, "");
        }
    }
}