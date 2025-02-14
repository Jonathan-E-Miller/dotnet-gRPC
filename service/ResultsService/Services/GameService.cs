using Grpc.Core;
using ResultsService.Protos;
using System.Text.Json;
using System.Threading.Tasks;

namespace ResultsService.Services
{
    public class ProductService : Product.ProductBase
    {
        private readonly ILogger<ProductService> _logger;

        public ProductService(ILogger<ProductService> logger)
        {
            _logger = logger;
        }

        public override Task<GetProductResponse> GetProduct(GetProductRequest request, ServerCallContext context)
        {
            var response = new GetProductResponse
            {
                Id = request.Id,
                Name = "Sample Product",
                Description = "This is a sample product.",
                Price = 99.99
            };

            return Task.FromResult(response);
        }

        public override Task<UpdateProductResponse> UpdateProduct(UpdateProductRequest request, ServerCallContext context)
        {
            var response = new UpdateProductResponse
            {
                Id = request.Id,
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            };

            return Task.FromResult(response);
        }

        public override Task<CreateProductResponse> CreateProduct(CreateProductRequest request, ServerCallContext context)
        {
            var response = new CreateProductResponse
            {
                Id = "new-id",
                Name = request.Name,
                Description = request.Description,
                Price = request.Price
            };

            return Task.FromResult(response);
        }

        public override Task<DeleteProductResponse> DeleteProduct(DeleteProductRequest request, ServerCallContext context)
        {
            var response = new DeleteProductResponse
            {
                Id = request.Id
            };


            return Task.FromResult(response);
        }
    }
}
