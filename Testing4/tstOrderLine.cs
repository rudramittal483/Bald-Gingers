using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingOrders
{
    [TestClass]
    public class tstOrderLine
    {
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
    }
}