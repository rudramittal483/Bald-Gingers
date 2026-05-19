using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstAddress
    {
        // Good test data for the Valid method
        string CustomerNo = "1";
        string Emirate = "Dubai";
        string BuildingName = "Burj Views";
        string StreetName = "Downtown Road";
        string AddressType = "Apartment";
        string Postcode = "12345";

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //test to see that it exists
            Assert.IsNotNull(AnAddress);
        }

        [TestMethod]
        public void AddressIdPropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            Int32 TestData = 1;
            AnAddress.AddressId = TestData;
            Assert.AreEqual(AnAddress.AddressId, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            Int32 TestData = 1;
            AnAddress.CustomerNo = TestData;
            Assert.AreEqual(AnAddress.CustomerNo, TestData);
        }

        [TestMethod]
        public void EmiratePropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "Dubai";
            AnAddress.Emirate = TestData;
            Assert.AreEqual(AnAddress.Emirate, TestData);
        }

        [TestMethod]
        public void BuildingNamePropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "Burj Views";
            AnAddress.BuildingName = TestData;
            Assert.AreEqual(AnAddress.BuildingName, TestData);
        }

        [TestMethod]
        public void StreetNamePropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "Downtown Road";
            AnAddress.StreetName = TestData;
            Assert.AreEqual(AnAddress.StreetName, TestData);
        }

        [TestMethod]
        public void AddressTypePropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "Apartment";
            AnAddress.AddressType = TestData;
            Assert.AreEqual(AnAddress.AddressType, TestData);
        }

        [TestMethod]
        public void PostcodePropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            Int32 TestData = 12345;
            AnAddress.Postcode = TestData;
            Assert.AreEqual(AnAddress.Postcode, TestData);
        }

        [TestMethod]
        public void IsDefaultPropertyOK()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean TestData = true;
            AnAddress.IsDefault = TestData;
            Assert.AreEqual(AnAddress.IsDefault, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 AddressId = 1;
            //invoke the method
            Found = AnAddress.Find(AddressId);
            //test to see if the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestAddressIdFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.AddressId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerNoFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.CustomerNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestEmirateFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.Emirate != "Dubai")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestBuildingNameFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.BuildingName != "Burj Views")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStreetNameFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.StreetName != "Downtown Road")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestAddressTypeFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.AddressType != "Apartment")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPostcodeFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.Postcode != 12345)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestIsDefaultFound()
        {
            clsAddress AnAddress = new clsAddress();
            Boolean Found = false;
            Boolean OK = true;
            Int32 AddressId = 1;
            Found = AnAddress.Find(AddressId);
            if (AnAddress.IsDefault != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //string variable to store any error message
            String Error = "";
            //invoke the method (assuming we pass the fields that user enters as text)
            Error = AnAddress.Valid(CustomerNo, Emirate, BuildingName, StreetName, AddressType, Postcode);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void BuildingNameMinLessOne()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string TestData = ""; //this should trigger an error because it's blank
            //invoke the method
            Error = AnAddress.Valid(CustomerNo, Emirate, TestData, StreetName, AddressType, Postcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void BuildingNameMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method (varchar is 50, so 51 should fail)
            string TestData = "".PadRight(51, 'a');
            //invoke the method
            Error = AnAddress.Valid(CustomerNo, Emirate, TestData, StreetName, AddressType, Postcode);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PostcodeInvalidData()
        {
            //create an instance of the class we want to create
            clsAddress AnAddress = new clsAddress();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method (Postcode is INT, this string should fail conversion)
            string TestData = "this is not a number!";
            //invoke the method
            Error = AnAddress.Valid(CustomerNo, Emirate, BuildingName, StreetName, AddressType, TestData);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}