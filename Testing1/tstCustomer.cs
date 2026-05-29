using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
        string CustomerNo = "1";
        string FirstName = "John";
        string LastName = "Smith";
        string Email = "john.smith@gaming.com";
        string DateJoined = DateTime.Now.Date.ToShortDateString();

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerNo = TestData;
            Assert.AreEqual(ACustomer.CustomerNo, TestData);
        }

        [TestMethod]
        public void FirstNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "John";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Smith";
            ACustomer.LastName = TestData;
            Assert.AreEqual(ACustomer.LastName, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "atif@example.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }

        [TestMethod]
        public void DateJoinedPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateJoined = TestData;
            Assert.AreEqual(ACustomer.DateJoined, TestData);
        }

        [TestMethod]
        public void IsActiveAccountPropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.IsActiveAccount = TestData;
            Assert.AreEqual(ACustomer.IsActiveAccount, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            Int32 CustomerNo = 1;
            //invoke the method
            Found = ACustomer.Find(CustomerNo);
            //check the customer no
            if (ACustomer.CustomerNo != 1)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestFirstNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.FirstName != "John")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestLastNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.LastName != "Smith")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.Email != "john.smith@gaming.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateJoinedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.DateJoined != new DateTime(2026, 1, 15))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsActiveAccountFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerNo = 1;
            Found = ACustomer.Find(CustomerNo);
            if (ACustomer.IsActiveAccount != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = ""; //this should trigger an error
                                  //invoke the method
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = "".PadRight(51, 'a');
            //invoke the method
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateJoinedInvalidData()
        {
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = "this is not a date!";
            //invoke the method
            Error = ACustomer.Valid(FirstName, LastName, Email, TestData);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "a"; // 1 character
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "aa"; // 2 characters
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(49, 'a'); // 49 characters
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(50, 'a'); // 50 characters
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(25, 'a'); // 25 characters
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void FirstNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(500, 'a'); // 500 characters
            Error = ACustomer.Valid(TestData, LastName, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        // ==========================================
        // LAST NAME BOUNDARY TESTS (1 to 50 chars)
        // ==========================================

        [TestMethod]
        public void LastNameMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = ""; // 0 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "a"; // 1 character
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "aa"; // 2 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(49, 'a'); // 49 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(50, 'a'); // 50 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(51, 'a'); // 51 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void LastNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(25, 'a'); // 25 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void LastNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(500, 'a'); // 500 characters
            Error = ACustomer.Valid(FirstName, TestData, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = ""; 
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "a"; 
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "aa"; 
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(49, 'a');
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(50, 'a');
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(51, 'a');
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(25, 'a');
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string TestData = "".PadRight(500, 'a');
            Error = ACustomer.Valid(FirstName, LastName, TestData, DateJoined);
            Assert.AreNotEqual(Error, "");
        }
        
        [TestMethod]
        public void DateExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100).AddDays(-1);
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100).AddDays(1);
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxMinusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxBoundary()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-50);
            string DateJoined = TestDate.ToString;
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100); // 100 years in the future
            string DateJoined = TestDate.ToString();
            Error = ACustomer.Valid(FirstName, LastName, Email, DateJoined);
            Assert.AreNotEqual(Error, "");
        }
    }
}



