using MobilApp.Entities;
using MobilApp.Repository;

namespace MobilApp.API.Services
{
    public class GroupService
    {
        private readonly IGroupRepository _repository;

        public GroupService(IGroupRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Groups> GetAllGroups()
        {
            return _repository.GetAll();
        }

        public Groups GetGroupById(int id)
        {
            return _repository.GetById(id);
        }

        public void AddGroup(Groups group)
        {
            _repository.Add(group);
        }
    }
}
