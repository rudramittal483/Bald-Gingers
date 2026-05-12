using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrders
{
    [TestClass]
    public class tstOrder
    {
        string CustomerNo = "1";
        string OrderDate = DateTime.Now.Date.ToShortDateString();
        string TotalAmount = "50.00";
        string DeliveryAddress = "Test Street";

        [TestMethod]
        public void InstanceOK()
        {
            // Create an instance of the class
            clsOrder AnOrder = new clsOrder();
            // Test to see that it exists
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void IsDispatchedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Create test data
            Boolean TestData = true;
            // Assign data to the property
            AnOrder.IsDispatched = TestData;
            // Test to see that the values are the same
            Assert.AreEqual(AnOrder.IsDispatched, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Create test data using today's date[cite: 4]
            DateTime TestData = DateTime.Now.Date;
            AnOrder.OrderDate = TestData;
            Assert.AreEqual(AnOrder.OrderDate, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.OrderNo = TestData;
            Assert.AreEqual(AnOrder.OrderNo, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Int32 TestData = 1;
            AnOrder.CustomerNo = TestData;
            Assert.AreEqual(AnOrder.CustomerNo, TestData);
        }

        [TestMethod]
        public void TotalAmountPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            // Use double for currency
            double TestData = 1499.99;
            AnOrder.TotalAmount = TestData;
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        [TestMethod]
        public void DeliveryAddressPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "123 Some Street, LE1 4AB";
            AnOrder.DeliveryAddress = TestData;
            Assert.AreEqual(AnOrder.DeliveryAddress, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsTrue(AnOrder.Find(1));
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = AnOrder.Find(21);
            Assert.AreEqual(AnOrder.OrderNo, 21);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = AnOrder.Find(1);
            Assert.IsTrue(AnOrder.CustomerNo == 1);
        }

        [TestMethod]
        public void TestOrderDateFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = AnOrder.Find(21);
            Assert.AreEqual(AnOrder.OrderDate, new DateTime(2026, 05, 07));
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = AnOrder.Find(1);
            Assert.IsTrue(AnOrder.TotalAmount == 50.00);
        }

        [TestMethod]
        public void TestDeliveryAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = AnOrder.Find(1);
            Assert.IsTrue(AnOrder.DeliveryAddress == "Test Street");
        }

        [TestMethod]
        public void TestIsDispatchedFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = AnOrder.Find(21);
            Assert.AreEqual(AnOrder.IsDispatched, true);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, "");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string TestData = "".PadRight(51, 'a');
            Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, "this is not a date!", TotalAmount, DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }
    }
}