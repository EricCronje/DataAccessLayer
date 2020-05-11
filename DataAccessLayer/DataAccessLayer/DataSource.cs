using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    internal class DataSource
    {
        public List<Order> Orders { get; internal set; }
        public List<Product> Products { get; internal set; }
        public List<User> Users { get; internal set; }

        public DataSource()
        {
            GetOrders();
            GetProducts();
            GetUsers();
        }

        private void GetUsers()
        {
            Users = new List<User>()
            {
                new SalesUser(1, "Jeff", "123", "Sales")
            };
        }

        private void GetProducts()
        {
            Products = new List<Product>()
            {
                new SalesProduct(1, "Chair", Convert.ToDecimal(201.00))
            };
        }

        private void GetOrders()
        {
            Orders = new List<Order>()
            {
                new SalesOrder(1,1,"Jack", Convert.ToDecimal(230.10), Convert.ToDecimal(232.10), Convert.ToDecimal(0.03))
            };

        }
    }

}