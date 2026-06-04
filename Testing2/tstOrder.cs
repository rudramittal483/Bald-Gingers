using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrders
{
    [TestClass]
    public class tstOrder
    {
        // Good test data
        string CustomerNo = "1";
        string OrderDate = DateTime.Now.Date.ToShortDateString();
        string TotalAmount = "50.00";
        string DeliveryAddress = "Test Street";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void IsDispatchedPropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.IsDispatched = TestData;
            Assert.AreEqual(AnOrder.IsDispatched, TestData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrder AnOrder = new clsOrder();
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
            Boolean Found = AnOrder.Find(1);
            Assert.AreEqual(AnOrder.OrderNo, 1);
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
            Boolean Found = AnOrder.Find(1);
            Assert.AreEqual(AnOrder.OrderDate, new DateTime(2026, 01, 05));
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
            Boolean Found = AnOrder.Find(1);
            Assert.AreEqual(AnOrder.IsDispatched, true);
        }

        // ==========================================
        // VALIDATION TESTS FOR DELIVERY ADDRESS
        // ==========================================

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, "");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, "");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, "A");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, "AB");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxMinusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "".PadRight(49, 'a');
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "".PadRight(50, 'a');
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "".PadRight(51, 'a');
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, TestData);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressMid()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "".PadRight(25, 'a');
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, TestData);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DeliveryAddressExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            string TestData = "".PadRight(500, 'a');
            String Error = AnOrder.Valid(CustomerNo, OrderDate, TotalAmount, TestData);
            Assert.AreNotEqual(Error, "");
        }

        // ==========================================
        // VALIDATION TESTS FOR ORDER DATE
        // ==========================================

        [TestMethod]
        public void OrderDateExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, "01/01/2000", TotalAmount, DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            string TestDate = DateTime.Now.Date.AddDays(-1).ToShortDateString();
            String Error = AnOrder.Valid(CustomerNo, TestDate, TotalAmount, DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string TestDate = DateTime.Now.Date.ToShortDateString();
            String Error = AnOrder.Valid(CustomerNo, TestDate, TotalAmount, DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMaxBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            string TestDate = DateTime.Now.Date.ToShortDateString();
            String Error = AnOrder.Valid(CustomerNo, TestDate, TotalAmount, DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            string TestDate = DateTime.Now.Date.AddDays(1).ToShortDateString();
            String Error = AnOrder.Valid(CustomerNo, TestDate, TotalAmount, DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, "01/01/3000", TotalAmount, DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderDateInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, "Not a Date", TotalAmount, DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        // ==========================================
        // VALIDATION TESTS FOR TOTAL AMOUNT
        // ==========================================

        [TestMethod]
        public void TotalAmountExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "-1000.00", DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "0.00", DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinBoundary()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "0.01", DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "0.02", DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "50.00", DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "1000000.00", DeliveryAddress);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = AnOrder.Valid(CustomerNo, OrderDate, "Fifty Bucks", DeliveryAddress);
            Assert.AreNotEqual(Error, "");
        }
    }
}