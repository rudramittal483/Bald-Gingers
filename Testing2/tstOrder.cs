using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrders
{
    [TestClass]
    public class tstOrder
    {
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
    }
}