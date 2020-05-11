using System;
using System.Collections.Generic;
using DataAccessLAyer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccessUnitTests
{
    [TestClass]
    public class GetUser
    {
        [TestMethod]
        public void GetUser_ValidUserID_ReturnUser()
        {
            try
            {
                using (var dataAccess = new DataAccessLAyer.DataAccess())
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
        public void AuthorizeUser_ValidUserAndPassword_ReturnTrue()
        {
            try
            {
                using (var dataAccess = new DataAccessLAyer.DataAccess())
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

    }

    [TestClass]
    public class GetProducts
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
    public class GetOrders
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
