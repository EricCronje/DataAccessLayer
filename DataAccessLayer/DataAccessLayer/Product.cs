namespace DataAccessLayer
{
    public class Product
    {

        public Product(int id, string productName, decimal itemCost)
        {
            Id = id;
            ProductName = productName;
            ItemCost = itemCost;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal ItemCost { get; set; }

    }
}