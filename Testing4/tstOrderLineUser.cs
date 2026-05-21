using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstOrderLineUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //test to see that the two values are the same
            Assert.IsNotNull(AnUser);
        }

        [TestMethod]
        public void UserIDPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnUser.UserID = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //create some test data to assign to the property
            string TestData = "Salaam";
            //assign the data to the property
            AnUser.UserName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.UserName, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //create some test data to assign to the property
            string TestData = "password";
            //assign the data to the property
            AnUser.Password = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Password, TestData);
        }


        [TestMethod]
        public void DepartmentPropertyOK()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //create some test data to assign to the property
            string TestData = "Order";
            //assign the data to the property
            AnUser.Department = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            string UserName = "Salaam";
            string Password = "password";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //test to see that the result is true
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestUserNamePWFound()
        {
            //create an instance of the class we want to create
            clsOrderLineUser AnUser = new clsOrderLineUser();
            //boolean variable to store the results of the validation
            Boolean Found = false;
            Boolean OK = true;
            //create some test data to use with the method
            string UserName = "Salaam";
            string Password = "password";
            //invoke the method
            Found = AnUser.FindUser(UserName, Password);
            //check the user id property
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
}