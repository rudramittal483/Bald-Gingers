using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //Add an Item to the List
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.IsActiveAccount = true;
            TestItem.CustomerNo = 1;
            TestItem.FirstName = "John";
            TestItem.LastName = "Smith";
            TestItem.Email = "john.smith@gaming.com";
            TestItem.DateJoined = new DateTime(2026, 1, 15);
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set the properties of the test object using the provided data
            TestCustomer.CustomerNo = 1; //
            TestCustomer.IsActiveAccount = true; //
            TestCustomer.FirstName = "John"; //
            TestCustomer.LastName = "Smith"; //
            TestCustomer.Email = "john.smith@gaming.com"; //
            TestCustomer.DateJoined = DateTime.Now.Date;
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.IsActiveAccount = true;
            TestItem.CustomerNo = 1;
            TestItem.DateJoined = DateTime.Now.Date;
            TestItem.FirstName = "Atif";
            TestItem.FirstName = "Suhail";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);
        }

    }
}
