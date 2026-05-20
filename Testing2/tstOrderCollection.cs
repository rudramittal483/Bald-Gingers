using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOrders
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            // Add an item to the list
            clsOrder TestItem = new clsOrder();
            TestItem.IsDispatched = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 50.00;
            TestItem.DeliveryAddress = "Test Street";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.IsDispatched = true;
            TestOrder.OrderNo = 1;
            TestOrder.CustomerNo = 1;
            TestOrder.OrderDate = DateTime.Now.Date;
            TestOrder.TotalAmount = 50.00;
            TestOrder.DeliveryAddress = "Test Street";
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.IsDispatched = true;
            TestItem.OrderNo = 1;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 50.00;
            TestItem.DeliveryAddress = "Test Street";
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.IsDispatched = true;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 50.00;
            TestItem.DeliveryAddress = "Test Street";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.IsDispatched = true;
            TestItem.CustomerNo = 1;
            TestItem.OrderDate = DateTime.Now.Date;
            TestItem.TotalAmount = 50.00;
            TestItem.DeliveryAddress = "Test Street";
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderNo = PrimaryKey;

            TestItem.IsDispatched = false;
            TestItem.CustomerNo = 2;
            TestItem.OrderDate = DateTime.Now.Date.AddDays(1);
            TestItem.TotalAmount = 99.99;
            TestItem.DeliveryAddress = "Updated Street";
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }
    }
}
