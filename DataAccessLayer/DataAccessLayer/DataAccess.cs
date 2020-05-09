using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
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
    public class DataAccess
    {
        private List<User> users = new List<User>();
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();

        public DataAccess()
        {
            users = new List<User>()
            {
                new User("Jack", "123", "Sales", 1)
            };

            products = new List<Product>()
            {
                new Product(1, "Chair", Convert.ToDecimal(200.00))
            };

            orders = new List<Order>
            {
                new Order(1, "ABC Sweets", Convert.ToDecimal(223.10), Convert.ToDecimal(230.00), 3 , 1)
            };
        }

        public User GetValidUser(int id)
        {
            try
            {
                return users.Where(u => u.Id == id)
                        .Select(t => t).SingleOrDefault();
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
                User user = users.Where(x => x.Name == userName)
                                 .Where(x => x.Password == password)
                                 .Select(y => y).FirstOrDefault();
                return user != null ? true : false;  
            }
            catch (Exception Ex)
            {

                throw Ex;
            }

        }

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
    }
}
