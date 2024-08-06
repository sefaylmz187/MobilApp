using MobilApp.Entities;
using MobilApp.Repository;

namespace MobilApp.API.Services
{
    public class BrandService
    {
        private readonly IBrandRepository _repository;

        public BrandService(IBrandRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Brands> GetAllBrands()
        {
            return _repository.GetAll();
        }

        public Brands GetBrandsById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddBrand(Brands brands)
        {
            _repository.Add(brands);
        }
    }
}
