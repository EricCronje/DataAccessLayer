using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Checklist:
    /// 
    /// DataAccess class - resposibilities:
    ///     1) provide a way to Get Users, Orders, Products and Authorize user data
    ///     
    /// Classes
    /// 1.) Single resposibility principle - Yes
    /// 2.) Open Close principle - Yes
    /// 3.) Liskov substitution principle - Yes 
    /// 4.) Interface Segregation principle - Yes
    /// 5.) Dependency Inversion principle - Yes
    /// 
    /// OOP:
    /// 1.) Encapsulation - Yes
    /// 2.) Abstraction - Yes
    /// 3.) Polymorphism - Yes
    /// 4.) Inheritance - Yes
    /// 5.) Association - No
    /// 6.) Agrigation - No
    /// 7.) Compostion - Yes
    /// 
    /// </summary>
    public class DataAccess : IDisposable , IOrders, IProducts, IUser
    {

        #region Declare Datastore variables - orders, products, users - stubData
        private List<Order> orders = null;
        private List<Product> products = null;
        private List<User> users = null;
        
        private DataSource dataSource = new DataSource();
        
        #endregion

        #region Constructors - parameterless constructor - initialize stubs - orders, users, products
        public DataAccess()
        {
            //Get the data from the datasource
            GetOrdersDataFromDataSource();
            GetProductsDataFromDataSource();
            GetUsersDataFromDataSource();
        }
        #endregion

        #region Get data from datasource - Orders, Products, Users
        private void GetOrdersDataFromDataSource()
        {
            orders = dataSource.Orders; 
        }

        private void GetProductsDataFromDataSource()
        {
            products = dataSource.Products;
        }

        private void GetUsersDataFromDataSource()
        {
            users = dataSource.Users;
        }
        #endregion

        #region Main methods - GetUser by id, GetProducts, GetOrders, AutorizeUser
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

        #region Dispose - implemented IDisposable method - dispose - Users, Products, Orders 
        public void Dispose()
        {
            users = null;
            products = null;
            orders = null;
        }
        #endregion

    }

}