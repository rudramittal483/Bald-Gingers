using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrderLines
{
    [TestClass]
    public class tstOrderLine
    {
        // Good test data
        string OrderNo = "1";
        string LaptopNo = "1";
        string Quantity = "1";

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsNotNull(AnOrderLine);
        }

        [TestMethod]
        public void OrderLineNoPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderLineNo = TestData;
            Assert.AreEqual(AnOrderLine.OrderLineNo, TestData);
        }

        [TestMethod]
        public void OrderNoPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.OrderNo = TestData;
            Assert.AreEqual(AnOrderLine.OrderNo, TestData);
        }

        [TestMethod]
        public void LaptopNoPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.LaptopNo = TestData;
            Assert.AreEqual(AnOrderLine.LaptopNo, TestData);
        }

        [TestMethod]
        public void QuantityPropertyOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Int32 TestData = 1;
            AnOrderLine.Quantity = TestData;
            Assert.AreEqual(AnOrderLine.Quantity, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Assert.IsTrue(AnOrderLine.Find(1));
        }

        [TestMethod]
        public void TestOrderLineNoFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = AnOrderLine.Find(1);
            Assert.IsTrue(AnOrderLine.OrderLineNo == 1);
        }

        [TestMethod]
        public void TestOrderNoFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = AnOrderLine.Find(1);
            Assert.IsTrue(AnOrderLine.OrderNo == 1);
        }

        [TestMethod]
        public void TestLaptopNoFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = AnOrderLine.Find(1);
            Assert.IsTrue(AnOrderLine.LaptopNo == 1);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            Boolean Found = AnOrderLine.Find(1);
            Assert.IsTrue(AnOrderLine.Quantity == 1);
        }

        // ==========================================
        // VALIDATION TESTS FOR QUANTITY
        // ==========================================

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, Quantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMin()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "-1000");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "0");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "1");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "2");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxMinusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "49");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxBoundary()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "50");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxPlusOne()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "51");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "25");
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityExtremeMax()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "1000");
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityInvalidDataType()
        {
            clsOrderLine AnOrderLine = new clsOrderLine();
            String Error = AnOrderLine.Valid(OrderNo, LaptopNo, "Fifty");
            Assert.AreNotEqual(Error, "");
        }
    }
}