using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrderLines
{
    [TestClass]
    public class tstOrderLine
    {
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
    }
}