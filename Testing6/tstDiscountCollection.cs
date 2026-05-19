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

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create some test data to assign to the property
            clsDiscount TestDiscount = new clsDiscount();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestDiscount.DiscountId = 6;
            TestDiscount.DiscountCode = "REFER10";
            TestDiscount.DiscountPercent = 10.00;
            TestDiscount.DiscountDescription = "Refering a friend bonus";
            TestDiscount.DiscountStartDate = DateTime.Now.Date;
            TestDiscount.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //set ThisDiscount to the test data
            AllDiscounts.ThisDiscount = TestDiscount;
            //add the record
            PrimaryKey = AllDiscounts.Add();
            //set the primary key of the test data
            TestDiscount.DiscountId = PrimaryKey;
            //find the record
            AllDiscounts.ThisDiscount.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDiscounts.ThisDiscount, TestDiscount);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create some test data to assign to the property
            clsDiscount TestDiscount = new clsDiscount();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestDiscount.DiscountId = 6;
            TestDiscount.DiscountCode = "REFER10";
            TestDiscount.DiscountPercent = 10.00;
            TestDiscount.DiscountDescription = "Refering a friend bonus";
            TestDiscount.DiscountStartDate = DateTime.Now.Date;
            TestDiscount.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //set ThisDiscount to the test data
            AllDiscounts.ThisDiscount = TestDiscount;
            //add the record
            PrimaryKey = AllDiscounts.Add();
            //set the primary key of the test data
            TestDiscount.DiscountId = PrimaryKey;
            //modify the test data
            TestDiscount.DiscountCode = "REFERAFRIEND";
            TestDiscount.DiscountPercent = 15.00;
            TestDiscount.DiscountDescription = "Referring a friend bonus";
            TestDiscount.DiscountStartDate = DateTime.Now.Date;
            TestDiscount.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //set the record based on the new test data
            AllDiscounts.ThisDiscount = TestDiscount;
            //update the record
            AllDiscounts.Update();
            //find the record
            AllDiscounts.ThisDiscount.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllDiscounts.ThisDiscount, TestDiscount);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create some test data to assign to the property
            clsDiscount TestDiscount = new clsDiscount();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set the properties of the test object
            TestDiscount.DiscountId = 6;
            TestDiscount.DiscountCode = "REFERAFRIEND";
            TestDiscount.DiscountPercent = 15.00;
            TestDiscount.DiscountDescription = "Refering a friend bonus";
            TestDiscount.DiscountStartDate = DateTime.Now.Date;
            TestDiscount.DiscountEndDate = DateTime.Now.Date.AddDays(30);
            //set ThisDiscount to the test data
            AllDiscounts.ThisDiscount = TestDiscount;
            //add the record
            PrimaryKey = AllDiscounts.Add();
            //set the primary key of the test data
            TestDiscount.DiscountId = PrimaryKey;
            //find the record
            AllDiscounts.ThisDiscount.Find(PrimaryKey);
            //delete the record
            AllDiscounts.Delete();
            //now find the record again
            Boolean Found = AllDiscounts.ThisDiscount.Find(PrimaryKey);
            //test to see that it was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByDiscountCodeMethodOK()
        {
            //create an instance of the class containing unfiltered results
            clsDiscountCollection AllDiscounts = new clsDiscountCollection();
            //create an instance of the class containing filtered results
            clsDiscountCollection FilteredDiscounts = new clsDiscountCollection();
            //apply a blank string (should return all records)
            FilteredDiscounts.ReportByDiscountCode("");
            //test to see that the two values are the same
            Assert.AreEqual(AllDiscounts.Count, FilteredDiscounts.Count);
        }

        [TestMethod]
        public void ReportByDiscountCodeNoneFound()
        {
            //create an instance of the class containing filtered results
            clsDiscountCollection FilteredDiscounts = new clsDiscountCollection();
            //apply a discount code that doesn't exist
            FilteredDiscounts.ReportByDiscountCode("xxxxx");
            //test to see that there are no records returned
            Assert.AreEqual(0, FilteredDiscounts.Count);
        }

        [TestMethod]
        public void ReportByDiscountCodeTestDataFound()
        {
            //create an instance of the class containing filtered results
            clsDiscountCollection FilteredDiscounts = new clsDiscountCollection();
            //var to store outcome
            Boolean OK = true;

            //apply a discount code you know exists in the database
            FilteredDiscounts.ReportByDiscountCode("REFERAFRIEND");

            //check that the correct number of records are found (should now be 2!)
            if (FilteredDiscounts.Count == 2)
            {
                //check that the first record is ID 7
                if (FilteredDiscounts.DiscountList[0].DiscountId != 7)
                {
                    OK = false;
                }
                //check that the second record is ID 15
                if (FilteredDiscounts.DiscountList[1].DiscountId != 15)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }

            //test to see that the outcome is true
            Assert.IsTrue(OK);
        }
    }
}
