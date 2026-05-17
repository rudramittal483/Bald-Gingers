using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;

namespace Testing6
{
    [TestClass]
    public class tstDiscount
    {


        //create some test data to use with the method
        string DiscountCode = "WELCOME10";
        string DiscountDescription = "Standard new customer signup bonus";
        string DiscountPercent = "10.00";
        string DiscountStartDate = DateTime.Now.Date.ToString();
        string DiscountEndDate = DateTime.Now.Date.AddDays(30).ToString();


        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //test to see that it exists
            Assert.IsNotNull(ADiscount);
        }

        [TestMethod]
        public void DiscountIdOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            ADiscount.DiscountId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADiscount.DiscountId, TestData);
        }

        [TestMethod]
        public void DiscountPercentOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //create some test data to assign to the property
            double TestData = 10.00;
            //assign the data to the property
            ADiscount.DiscountPercent = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADiscount.DiscountPercent, TestData);
        }

        [TestMethod]
        public void DiscountCodeOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //create some test data to assign to the property
            string TestData = "WELCOME10";
            //assign the data to the property
            ADiscount.DiscountCode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADiscount.DiscountCode, TestData);
        }

        [TestMethod]
        public void DiscountDescriptionOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //create some test data to assign to the property
            string TestData = "Standard new customer signup bonus";
            //assign the data to the property
            ADiscount.DiscountDescription = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADiscount.DiscountDescription, TestData);
        }

        [TestMethod]
        public void DiscountStartDateOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ADiscount.DiscountStartDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADiscount.DiscountStartDate, TestData);
        }

        [TestMethod]
        public void DiscountEndDateOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date.AddDays(30);
            //assign the data to the property
            ADiscount.DiscountEndDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ADiscount.DiscountEndDate, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestDiscountIdFound()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (initially set to true)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            //check the discount id property
            if (ADiscount.DiscountId != DiscountId)
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDiscountCodeFound()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (initially set to true)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            //check the discount code property
            if (ADiscount.DiscountCode != "WELCOME10")
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDiscountDescriptionFound()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (initially set to true)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            //check the discount description property
            if (ADiscount.DiscountDescription != "Standard new customer signup bonus")
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDiscountPercentFound()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (initially set to true)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            //check the discount percent property
            if (ADiscount.DiscountPercent != 10.00)
            {
                OK = false;
            }
            //test to see that the result is true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDiscountStartDateFound()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (initially set to true)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            //check the discount start date property
            if (ADiscount.DiscountStartDate != Convert.ToDateTime("01/01/2026"))
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDiscountEndDateFound()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create a boolean variable to record if the data is OK (initially set to true)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 DiscountId = 1;
            //invoke the method
            Found = ADiscount.Find(DiscountId);
            if (ADiscount.DiscountEndDate != Convert.ToDateTime("31/12/2026"))
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
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ADiscount.Valid(DiscountCode, DiscountDescription, DiscountPercent, DiscountStartDate, DiscountEndDate);
            //test to see that the result is correct (there should be no error message)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountCodeMinLessOne()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = ""; //this should trigger an error message as it's less than the minimum length
            //invoke the method
            Error = ADiscount.Valid(TestData, DiscountDescription, DiscountPercent, DiscountStartDate, DiscountEndDate);
            //test to see that the result is correct (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountCodeMin()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = "A"; //this should be fine as it's exactly the minimum length
            //invoke the method
            Error = ADiscount.Valid(TestData, DiscountDescription, DiscountPercent, DiscountStartDate, DiscountEndDate);
            //test to see that the result is correct (there should be no error message)
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DiscountStartDateInvalid()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = "invalid date"; //this should trigger an error message as it's not a valid date
            //invoke the method
            Error = ADiscount.Valid(DiscountCode, DiscountDescription, DiscountPercent, TestData, DiscountEndDate);
            //test to see that the result is correct (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountEndDateInvalid()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = "invalid date"; //this should trigger an error message as it's not a valid date
            //invoke the method
            Error = ADiscount.Valid(DiscountCode, DiscountDescription, DiscountPercent, DiscountStartDate, TestData);
            //test to see that the result is correct (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DiscountPercentInvalid()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = "invalid percent"; //this should trigger an error message as it's not a valid double
            //invoke the method
            Error = ADiscount.Valid(DiscountCode, DiscountDescription, TestData, DiscountStartDate, DiscountEndDate);
            //test to see that the result is correct (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DescriptionInvalid()
        {
            //create an instance of the class we want to create
            clsDiscount ADiscount = new clsDiscount();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = ""; //this should trigger an error message as it's less than the minimum length
            //invoke the method
            Error = ADiscount.Valid(DiscountCode, TestData, DiscountPercent, DiscountStartDate, DiscountEndDate);
            //test to see that the result is correct (there should be an error message)
            Assert.AreNotEqual(Error, "");
        }
    }
}