using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLAyer
{
    /// <summary>
    /// Version:
    /// 1.0.0.0
    /// 
    /// Author:
    /// Eric Cronje
    /// 
    /// Date:
    /// 2020-05-09
    /// 
    /// Purpose:
    /// --------
    /// Separate the data operations from the main program
    ///
    /// </summary>
    public class DataAccess : IDisposable
    {
        private List<User> users = null;

        public DataAccess()
        {
            users = new List<User>()
            {
                new User(1, "Jeff", "123", "Sales")
            };
        }

        public void Dispose()
        {
            users = null;
        }

        public User GetUser(int id)
        {
            try
            {
                return users.Where(u => u.Id == id)
                            .Select(u => u).SingleOrDefault();
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }

        public bool AuthorizeUser(string userName, string password)
        {
            try
            {
                User user = users.Where(u => u.Name == userName)
                            .Where(v => v.Password == password)
                            .Select(u => u).SingleOrDefault();
                return user != null ? true : false;
            }
            catch (Exception Ex)
            {

                throw Ex;
            }
        }
    }
}
