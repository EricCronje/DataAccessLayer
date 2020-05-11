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
    /// 2020-05-11
    /// 
    /// Purpose:
    /// --------
    /// Separate the data operations from the main program.
    ///
    /// Dummy DAL.
    /// 
    /// Contains:
    /// ---------
    /// 3 datastores
    /// users           --  List of users.
    /// products        --  List of products.
    /// orders          --  List of history orders.
    /// 
    /// Default - parameterless constructor.
    /// 
    /// Initialize the 3 stubs in the constructor.
    /// -- users        -- GetUsersStubData
    /// -- products     -- GetProductsStubData
    /// -- orders       -- GetOrdersStubData
    /// 
    /// 
    /// 
    /// 
    /// </summary>
    public class DataAccess : IDisposable
    {
        #region Datastore declarations
        private List<Order> orders = null;
        private List<Product> products = null;
        private List<User> users = null;
        #endregion

        #region Constructors
        public DataAccess()
        {
            //Initialize the stub data.
            GetOrdersStubData();
            GetProductsStubData();
            GetUsersStubData();
        }
        #endregion

        #region Get stub data
        private void GetOrdersStubData()
        {
            //intantiates a generic list of order making up orders.
            orders = new List<Order>()
            {
                new Order(1,1,"Jack", Convert.ToDecimal(230.10), Convert.ToDecimal(232.10), Convert.ToDecimal(0.03))
            };
        }

        private void GetProductsStubData()
        {
            products = new List<Product>()
            {
                new Product(1, "Chair", Convert.ToDecimal(201.00))
            };
        }

        private void GetUsersStubData()
        {
            users = new List<User>()
            {
                new User(1, "Jeff", "123", "Sales")
            };

        }
        #endregion

        #region Main methods
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

        public List<Product> GetProducts()
        {
            return products;
        }

        public List<Order> GetOrders()
        {
            return orders;
        }
        #endregion

        #region Dispose
        public void Dispose()
        {
            users = null;
            products = null;
            orders = null;
        }
        #endregion

    }
}