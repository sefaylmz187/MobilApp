namespace MobilApp.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        IGroupRepository Group { get; }
        IBrandRepository Brand { get; }
        ICategoryRepository Category { get; }
        int Save();
    }
}
