namespace MobilApp.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        int Save();
    }
}
