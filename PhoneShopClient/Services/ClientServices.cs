using PhoneShopSharedLibrary.Contracts;
using PhoneShopSharedLibrary.Models;
using PhoneShopSharedLibrary.Responses;

namespace PhoneShopClient.Services;

public class ClientServices : IProduct
{
    public Task<ServiceResponse> AddProduct(Product model)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetAllProducts(bool featuredProducts)
    {
        throw new NotImplementedException();
    }
}