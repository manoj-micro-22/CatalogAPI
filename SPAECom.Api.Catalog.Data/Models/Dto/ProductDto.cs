namespace SPAECom.Api.Catalog.Data.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double UnitPrice { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
