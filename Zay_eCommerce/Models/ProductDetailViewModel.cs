namespace Zay_eCommerce.Models
{
    public class ProductDetailViewModel
    {

        public int Id { get; set; }
        public string ProductName { get; set; } = "";
        public string ProductImage { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public string Brand { get; set; } = "";
        public string Size { get; set; } = "";
        public int Quantity { get; set; }

        public List<string> Images { get; set; } = new();

    }
}
