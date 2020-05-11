using System;
using System.Collections.Generic;
using DataAccessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccessLayer
{
    [TestClass]
    public class Users
    {
        [TestMethod]
        public void GetUser_ValidUserID_ReturnUser()
        {
            try
            {
                using (var dataAccess = new DataAccessLayer.DataAccess())
                {
                    User user = dataAccess.GetUser(1);
                    Assert.AreEqual(user.Id, 1);
                }
            }
            catch(Exception EX)
            {
                throw EX;
            }
        }

        [TestMethod]
        public void GetUser_InValidUserID_ReturnNull()
        {
            try
            {
                using (var dataAccess = new DataAccessLayer.DataAccess())
                {
                    User user = dataAccess.GetUser(23);
                    Assert.AreEqual(user, null);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        [TestMethod]
        public void AuthorizeUser_ValidUserAndPassword_ReturnTrue()
        {
            try
            {
                using (var dataAccess = new DataAccessLayer.DataAccess())
                {
                    bool result = dataAccess.AuthorizeUser("Jeff", "123");
                    Assert.AreEqual(result, true);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        [TestMethod]
        public void AuthorizeUser_InValidUserAndPassword_ReturnFalse()
        {
            try
            {
                using (var dataAccess = new DataAccessLayer.DataAccess())
                {
                    bool result = dataAccess.AuthorizeUser("Jeffrey", "123456");
                    Assert.AreEqual(result, false);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        [TestMethod]
        public void AuthorizeUser_InValidUserInformationNulls_ReturnFalse()
        {
            try
            {
                using (var dataAccess = new DataAccessLayer.DataAccess())
                {
                    bool result = dataAccess.AuthorizeUser(null, null);
                    Assert.AreEqual(result, false);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

        [TestMethod]
        public void AuthorizeUser_InValidInformationInvalidCharacters_ReturnFalse()
        {
            try
            {
                using (var dataAccess = new DataAccessLayer.DataAccess())
                {
                    bool result = dataAccess.AuthorizeUser("'~`!@#$%^&*()_+{[}]|\\/.,", "");
                    Assert.AreEqual(result, false);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

    }

    [TestClass]
    public class Products
    {
        [TestMethod]
        public void GetProducts_ReturnProducts()
        {
            try
            {
                using (var dataAccess = new DataAccess())
                {
                    List<Product> products = dataAccess.GetProducts();
                    Assert.AreEqual(products.Count, 1);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

    }

    [TestClass]
    public class Orders
    {
        [TestMethod]
        public void GetOrders_ReturnOrders()
        {
            try
            {
                using (var dataAccess = new DataAccess())
                {
                    List<Order> orders = dataAccess.GetOrders();
                    Assert.AreEqual(orders.Count, 1);
                }
            }
            catch (Exception EX)
            {
                throw EX;
            }
        }

    }

}
