using TA2.DTOs;

namespace TA2.Interfaces;

public interface IDataProvider
{
    public IEnumerable<ProductDTO>? GetProducts();
    public void AddProduct(ProductDTO product);
}