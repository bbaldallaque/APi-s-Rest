namespace Shoping.Model.Dto
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public double SalePrice { get; set; }

        public double PurchasePrice { get; set; }

        public int Stock { get; set; }
    }
}
