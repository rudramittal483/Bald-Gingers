using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstCustomer
    {
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
            string TestData = "Atif";
            ACustomer.FirstName = TestData;
            Assert.AreEqual(ACustomer.FirstName, TestData);
        }

        [TestMethod]
        public void LastNamePropertyOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "Ahmed";
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
    }
}

