namespace DataAccessLayer
{
    internal class SalesOrder : Order
    {
        public SalesOrder(int id, int quantity, string customerName, decimal salesWithDiscountVAT, decimal salesWithoutDiscountVAT, decimal salesDiscountPercentage) : base(id, quantity, customerName, salesWithDiscountVAT, salesWithoutDiscountVAT, salesDiscountPercentage)
        {
        }
    }
}