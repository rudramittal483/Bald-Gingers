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

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.LaptopNo = 1;
            TestItem.Quantity = 5;
            AllLines.ThisOrderLine = TestItem;
            PrimaryKey = AllLines.Add();
            TestItem.OrderLineNo = PrimaryKey;
            AllLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            clsOrderLine TestItem = new clsOrderLine();
            Int32 PrimaryKey = 0;
            TestItem.OrderNo = 1;
            TestItem.LaptopNo = 1;
            TestItem.Quantity = 5;
            AllLines.ThisOrderLine = TestItem;
            PrimaryKey = AllLines.Add();
            TestItem.OrderLineNo = PrimaryKey;

            TestItem.OrderNo = 2;
            TestItem.LaptopNo = 2;
            TestItem.Quantity = 10;
            AllLines.ThisOrderLine = TestItem;
            AllLines.Update();
            AllLines.ThisOrderLine.Find(PrimaryKey);
            Assert.AreEqual(AllLines.ThisOrderLine, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            // Create an instance of the class we want to create
            clsOrderLineCollection AllLines = new clsOrderLineCollection();
            // Create the item of test data
            clsOrderLine TestItem = new clsOrderLine();
            // Variable to store the primary key
            Int32 PrimaryKey = 0;

            // Set its properties
            TestItem.OrderNo = 1;
            TestItem.LaptopNo = 1;
            TestItem.Quantity = 5;

            // Set ThisOrderLine to the test data
            AllLines.ThisOrderLine = TestItem;
            // Add the record
            PrimaryKey = AllLines.Add();
            // Set the primary key of the test data
            TestItem.OrderLineNo = PrimaryKey;

            // Find the record
            AllLines.ThisOrderLine.Find(PrimaryKey);

            // Delete the record
            AllLines.Delete();

            // Now attempt to find it again
            Boolean Found = AllLines.ThisOrderLine.Find(PrimaryKey);

            // Test to see that the record was not found (it should be false)
            Assert.IsFalse(Found);
        }
    }
}
