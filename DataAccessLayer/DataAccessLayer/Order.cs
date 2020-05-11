namespace DataAccessLayer
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public decimal SalesWithDiscountVAT { get; set; }
        public decimal SalesWithoutDiscountVAT { get; set; }
        public decimal SalesDiscountPercentage { get; set; }

        public Order(
            int id,
            int quantity,
            string customerName,
            decimal salesWithDiscountVAT,
            decimal salesWithoutDiscountVAT,
            decimal salesDiscountPercentage
            )
        {
            Id = id;
            Quantity = quantity;
            CustomerName = customerName;
            SalesWithDiscountVAT = salesWithDiscountVAT;
            SalesWithoutDiscountVAT = salesWithoutDiscountVAT;
            SalesDiscountPercentage = salesDiscountPercentage;
        }
    }
}