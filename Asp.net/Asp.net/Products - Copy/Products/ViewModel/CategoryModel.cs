namespace Products.ViewModel
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string ImageURL { get; set; }

        public IFormFile File { get; set; }
    }
}
