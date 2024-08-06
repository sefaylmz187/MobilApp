using MobilApp.Entities;
using MobilApp.Repository;

namespace MobilApp.API.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Products GetProductById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddProduct(Products products)
        {
            _repository.Add(products);
        }
    }
}
