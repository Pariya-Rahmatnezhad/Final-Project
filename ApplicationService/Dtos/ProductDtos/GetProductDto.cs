
namespace ApplicationService.Dtos.ProductDtos
{
    public class GetProductDto
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Title { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
