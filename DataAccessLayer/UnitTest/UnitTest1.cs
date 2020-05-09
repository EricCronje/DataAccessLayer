using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using DataAccessLayer;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        

        [TestMethod]
        public void GetUser_UseValidID_ReturnUser()
        {

            var dataAccess = getDataAccess();

            try
            {
                User user = dataAccess.GetValidUser(1);
                Assert.AreEqual(user.Id, 1);
            }
            catch (System.Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        private DataAccessLayer.DataAccess getDataAccess()
        {
            DataAccessLayer.DataAccess dataAccess = new DataAccess();
            return dataAccess;
        }

        [TestMethod]
        public void AuthorizeUser_UseValidUsernameAndPassword_ReturnTrue()
        {
            var dataAccess = getDataAccess();

            try
            {
                bool result = dataAccess.AuthorizeUser("Jack", "123");
                Assert.AreEqual(result, true);
            }
            catch (System.Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        [TestMethod]
        public void GetProducts_GetAllProducts_ReturnListOfProducts()
        {
            var dataAccess = getDataAccess();

            try
            {
                var products = dataAccess.GetProducts();
                Assert.AreEqual(products.Count, 1);
            }
            catch (System.Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        [TestMethod]
        public void GetOrders_GetHistoryOrders_ReturnListOfOrders()
        {
            var dataAccess = getDataAccess();

            try
            {
                List<Order> orders = dataAccess.GetOrders();
                Assert.AreEqual(orders.Count, 1);
            }
            catch (System.Exception Ex)
            {

                throw Ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

    }
}
