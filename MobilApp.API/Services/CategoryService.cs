using MobilApp.Entities;
using MobilApp.Repository;

namespace MobilApp.API.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Categories> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public Categories GetCategoryById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddCategory(Categories categories)
        {
            _repository.Add(categories);
        }
    }
}
