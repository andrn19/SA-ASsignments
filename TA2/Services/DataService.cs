using TA2.Data_Providers;
using TA2.DTOs;
using TA2.Interfaces;

namespace TA2.Services;

public class DataService
{
    // The readonly keyword ensures that the variable's value can only be set within the constructor
    private readonly IEnumerable<ProductDTO> _products;
    
    // We ask for the environment in the constructor.
    // The framework will automatically provide it when the service is called.
    public DataService(IWebHostEnvironment webHostEnvironment)
    {
        // Here we use our brand new data provider to give us the data to pass on to whoever calls the service
        // Note that we declared the variable using the interface.
        IDataProvider provider = new JsonDataProvider();
        _products = provider.GetProducts();
    }

    public IEnumerable<ProductDTO> GetProducts()
    {
        return _products;
    }
}