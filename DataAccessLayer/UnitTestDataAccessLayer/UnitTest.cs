using System;
using System.CodeDom;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestDataAccessLayer
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void GetUser_UsingValidID_returnValidUser()
        {
            DataAccessLayer.DataAccess dataAccess = null;
            try
            {
                dataAccess = new DataAccessLayer.DataAccess();
                var user = dataAccess.GetUser(1);
                Assert.AreEqual(user.id, 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        [TestMethod]
        public void GetUser_UsingInvalidID_ReturnNothing()
        {
            DataAccessLayer.DataAccess dataAccess = null;
            try
            {
                dataAccess = new DataAccessLayer.DataAccess();
                var user = dataAccess.GetUser(0);
                Assert.AreEqual(user, null);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        [TestMethod]
        public void AuthorizeUser_ValidUserAndPassword_returnTrue()
        {
            DataAccessLayer.DataAccess dataAccess = null;
            try
            {
                dataAccess = new DataAccessLayer.DataAccess();
                var result = dataAccess.AuthorizeUser("Frank", "123");
                Assert.AreEqual(result, true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        [TestMethod]
        public void AuthorizeUser_InValidUserAndPassword_returnFalse()
        {
            DataAccessLayer.DataAccess dataAccess = null;
            try
            {
                dataAccess = new DataAccessLayer.DataAccess();
                var result = dataAccess.AuthorizeUser("Franky", "1234");
                Assert.AreEqual(result, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

        [TestMethod]
        public void AuthorizeUser_InValidUserAndPassword_Null_returnFalse()
        {
            DataAccessLayer.DataAccess dataAccess = null;
            try
            {
                dataAccess = new DataAccessLayer.DataAccess();
                var result = dataAccess.AuthorizeUser(null, null);
                Assert.AreEqual(result, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dataAccess = null;
            }
        }

    }
}
