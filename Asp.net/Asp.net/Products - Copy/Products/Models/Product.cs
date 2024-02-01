namespace Products.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int CategoryId { get; set; }
        public string ImageURL { get; set; }
        public Category Category { get; set; }
    }
}
