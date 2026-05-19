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
    public class tstAddressCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsAddressCollection AllAddresses = new clsAddressCollection();
            Assert.IsNotNull(AllAddresses);
        }

        [TestMethod]
        public void AddressListOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsAddress> TestList = new List<clsAddress>();
            //Add an Item to the List
            //create the item of test data
            clsAddress TestItem = new clsAddress();
            //set its properties
            TestItem.AddressId = 1;
            TestItem.CustomerNo = 1;
            TestItem.Emirate = "Dubai";
            TestItem.BuildingName = "Burj Views";
            TestItem.StreetName = "Downtown Road";
            TestItem.AddressType = "Apartment";
            TestItem.Postcode = 12345;
            TestItem.IsDefault = true;
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllAddresses.AddressList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.AddressList, TestList);
        }

        [TestMethod]
        public void ThisAddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create some test data to assign to the property
            clsAddress TestAddress = new clsAddress();
            //set the properties of the test object using the provided data
            TestAddress.AddressId = 1;
            TestAddress.CustomerNo = 1;
            TestAddress.Emirate = "Dubai";
            TestAddress.BuildingName = "Burj Views";
            TestAddress.StreetName = "Downtown Road";
            TestAddress.AddressType = "Apartment";
            TestAddress.Postcode = 12345;
            TestAddress.IsDefault = true;

            AllAddresses.ThisAddress = TestAddress;
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestAddress);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsAddressCollection AllAddresses = new clsAddressCollection();
            List<clsAddress> TestList = new List<clsAddress>();
            clsAddress TestItem = new clsAddress();

            TestItem.AddressId = 1;
            TestItem.CustomerNo = 1;
            TestItem.Emirate = "Dubai";
            TestItem.BuildingName = "Burj Views";
            TestItem.StreetName = "Downtown Road";
            TestItem.AddressType = "Apartment";
            TestItem.Postcode = 12345;
            TestItem.IsDefault = true;

            TestList.Add(TestItem);
            AllAddresses.AddressList = TestList;
            Assert.AreEqual(AllAddresses.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class we want to create
            clsAddressCollection AllAddresses = new clsAddressCollection();
            //create the item of test data
            clsAddress TestItem = new clsAddress();
            //variable to store the primary key
            Int32 PrimaryKey = 0;

            //set its properties
            TestItem.AddressId = 1;
            TestItem.CustomerNo = 1;
            TestItem.Emirate = "Dubai";
            TestItem.BuildingName = "Burj Views";
            TestItem.StreetName = "Downtown Road";
            TestItem.AddressType = "Apartment";
            TestItem.Postcode = 12345;
            TestItem.IsDefault = true;

            //set ThisAddress to the test data
            AllAddresses.ThisAddress = TestItem;
            //add the record
            PrimaryKey = AllAddresses.Add();
            //set the primary key of the test data
            TestItem.AddressId = PrimaryKey;
            //find the record
            AllAddresses.ThisAddress.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllAddresses.ThisAddress, TestItem);
        }
    }
}