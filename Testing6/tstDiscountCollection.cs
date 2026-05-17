using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstDiscountCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //test to see that it exists
            Assert.IsNotNull(AllDiscounts);
        }

        [TestMethod]
        public void DiscountListOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects with the same properties as clsDiscount
            List<clsDiscount> TestList = new List<clsDiscount>();
            //add an item to the list
            //create the item of test data
            clsDiscount TestItem = new clsDiscount();
            //set its properties
            TestItem.DiscountId = 1;
            TestItem.DiscountCode = "WELCOME10";
            TestItem.DiscountPercent = 10.00;
            TestItem.DiscountDescription = "Standard new customer signup bonus";
            TestItem.DiscountStartDate = DateTime.Now.Date;
            TestItem.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllDiscounts.DiscountList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllDiscounts.DiscountList, TestList);
        }

        [TestMethod]
        public void ThisDiscountPropertyOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create some test data to assign to the property
            clsDiscount TestDiscount = new clsDiscount();
            //set the properties of the test object
            TestDiscount.DiscountId = 1;
            TestDiscount.DiscountCode = "WELCOME10";
            TestDiscount.DiscountPercent = 10.00;
            TestDiscount.DiscountDescription = "Standard new customer signup bonus";
            TestDiscount.DiscountStartDate = DateTime.Now.Date;
            TestDiscount.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //assign the data to the property
            AllDiscounts.ThisDiscount = TestDiscount;
            //test to see that the two values are the same
            Assert.AreEqual(AllDiscounts.ThisDiscount, TestDiscount);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create some test data to assign to the property
            List<clsDiscount> TestList = new List<clsDiscount>();
            //add an item to the list
            //create the item of test data
            clsDiscount TestItem = new clsDiscount();
            //set its properties
            TestItem.DiscountId = 1;
            TestItem.DiscountCode = "WELCOME10";
            TestItem.DiscountPercent = 10.00;
            TestItem.DiscountDescription = "Standard new customer signup bonus";
            TestItem.DiscountStartDate = DateTime.Now.Date;
            TestItem.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //add the item to the list
            TestList.Add(TestItem);
            //assign the data to the property
            AllDiscounts.DiscountList = TestList;
            //test to see that the count of items in the list matches the count property
            Assert.AreEqual(AllDiscounts.Count, 1);
        }
    }
}
