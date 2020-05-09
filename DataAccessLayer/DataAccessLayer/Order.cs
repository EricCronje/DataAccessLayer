namespace DataAccessLayer
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public decimal SalesWithDiscountVAT { get; set; }
        public decimal SalesWithOutDiscountVAT { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int Quantity { get; set; }

        public Order(int id, string customerName, decimal salesWithDiscountVat, decimal salesWithOutDiscountVat, decimal discountPercentage, int quantity)
        {
            Id = id;
            CustomerName = customerName;
            SalesWithDiscountVAT = salesWithDiscountVat;
            SalesWithOutDiscountVAT = salesWithOutDiscountVat;
            DiscountPercentage = discountPercentage;
            Quantity = quantity;
        }

    }
}