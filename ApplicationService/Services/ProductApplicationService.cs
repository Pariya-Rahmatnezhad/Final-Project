using ApplicationService.Dtos.ProductDtos;
using Model.DomainModel;
using Model.ServiceModels;


namespace ApplicationService.Services
{
    public class ProductApplicationService
    {
        private readonly ProductServiceModel _productServiceModel;

        public ProductApplicationService()
        {
            _productServiceModel = new ProductServiceModel();
        }

        #region [- GetAll() -]
        public List<GetProductDto> GetAll()
        {
            var products = _productServiceModel.SellectAll();
            var GetProductDtos = new List<GetProductDto>();

            foreach (var product in products)
            {
                var getProductDto = new GetProductDto()
                {
                    Id = product.Id,
                    Code = product.Code,
                    Title = product.Title,
                    UnitPrice = product.UnitPrice,
                    Quantity = product.Quantity,
                };
                GetProductDtos.Add(getProductDto);
            }
            return GetProductDtos;
        }
        #endregion

        #region [- Post() -]
        public void Post(PostProductDto postProductDto)
        {
            var product = new Product()
            {
                Code = postProductDto.Code,
                Title = postProductDto.Title,
                UnitPrice = postProductDto.UnitPrice,
                Quantity = postProductDto.Quantity,
            };
            _productServiceModel.Insert(product);
        }
        #endregion

        #region [- Put() -]
        public void Put(PutProductDto putProductDto)
        {
            var product = new Product()
            {
                Id = putProductDto.Id,
                Code = putProductDto.Code,
                Title = putProductDto.Title,
                UnitPrice = putProductDto.UnitPrice,
                Quantity = putProductDto.Quantity,
            };
            _productServiceModel.Update(product);
        }
        #endregion

        #region [- Delete() -]
        public void Delete(DeleteProductDto deleteProductDto)
        {
            var product = new Product()
            {
                Id = deleteProductDto.Id,
            };

            _productServiceModel.Delete(product);
        } 
        #endregion
    }
}
