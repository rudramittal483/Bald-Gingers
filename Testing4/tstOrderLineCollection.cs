using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOrderLines
{
    [TestClass]
    public class tstOrderLineCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            Assert.IsNotNull(AllOrderLines);
        }

        [TestMethod]
        public void OrderLineListOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            // Set properties for the line item
            TestItem.OrderLineNo = 1;
            TestItem.OrderNo = 1;
            TestItem.LaptopNo = 1;
            TestItem.Quantity = 5;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.OrderLineList, TestList);
        }

        [TestMethod]
        public void ThisOrderLinePropertyOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineNo = 1;
            TestItem.OrderNo = 1;
            TestItem.LaptopNo = 1;
            TestItem.Quantity = 5;
            AllOrderLines.ThisOrderLine = TestItem;
            Assert.AreEqual(AllOrderLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderLineCollection AllOrderLines = new clsOrderLineCollection();
            List<clsOrderLine> TestList = new List<clsOrderLine>();
            clsOrderLine TestItem = new clsOrderLine();
            TestItem.OrderLineNo = 1;
            TestItem.OrderNo = 1;
            TestItem.LaptopNo = 1;
            TestItem.Quantity = 5;
            TestList.Add(TestItem);
            AllOrderLines.OrderLineList = TestList;
            Assert.AreEqual(AllOrderLines.Count, TestList.Count);
        }
    }
}
