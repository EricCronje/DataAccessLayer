using System.Collections.Generic;

namespace DataAccessLayer
{
    internal interface IOrders
    {
        List<Order> GetOrders();
    }
}