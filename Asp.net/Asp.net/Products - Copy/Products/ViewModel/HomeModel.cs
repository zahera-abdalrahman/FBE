using Products.Models;

namespace Products.ViewModel
{
    public class HomeModel
    {
        public List<Product> ProductList { get; set; }
        public List<Category> CategoryList { get; set; }
    }
}
