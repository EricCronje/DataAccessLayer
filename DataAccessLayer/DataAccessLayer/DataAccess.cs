using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// Version:
    /// 1.0.0.0
    /// 
    /// Author:
    /// Eric Cronje
    /// 
    /// Date:
    /// 2020-05-08
    /// 
    /// Purpose:
    /// --------
    /// Separate the data operations from the main program
    ///
    /// </summary>
    /// 
    public class DataAccess
    {

        private List<User> users;

        public DataAccess()
        {
            users = new List<User> {
                new User("Frank", "123", "admin", 1),
                new User("Jen", "123", "sales", 2)
            };
        }
        
        public User GetUser(int id)
        {
            try
            {
                return users.Where(x => x.id == id)
                                   .Select(x => x)
                                   .FirstOrDefault();               
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool AuthorizeUser(string userName, string password)
        {

            var user = users.Where(u => u.name == userName)
                 .Where(u => u.password == password)
                 .Select(v => v)
                 .SingleOrDefault();

            return user == null ? false : true; 

        }


    }
}
