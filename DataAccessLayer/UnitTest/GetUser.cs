using System;
using DataAccessLAyer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataAccess
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
}
