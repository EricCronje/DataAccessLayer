using System.Collections.Generic;

namespace DataAccessLayer
{
    internal interface IProducts
    {
        List<Product> GetProducts();
    }
}