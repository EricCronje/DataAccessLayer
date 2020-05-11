namespace DataAccessLayer
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ProductCost { get; set; }

        public Product(int id, string productName, decimal productCost)
        {
            Id = id;
            ProductName = productName;
            ProductCost = productCost;
        }
    }
}