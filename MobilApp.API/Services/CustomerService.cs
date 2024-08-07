using MobilApp.Entities;
using MobilApp.Repository;

namespace MobilApp.API.Services
{
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAll();
        }

        public Customer GetCustomerById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddCustomer(Customer customers)
        {
            _repository.Add(customers);
        }
    }
}
