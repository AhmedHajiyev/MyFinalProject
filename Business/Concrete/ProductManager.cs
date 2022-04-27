using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ProductManager : IProductService
{
    IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = productDal;
    }

    public List<Product> GetAll()
    {
        
        // _productDal dataAccess folderindeki IProductDal interfacedeki methodlari cagirmaga xidmet edir
        return _productDal.GetAll();
    }
}