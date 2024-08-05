namespace MobilApp.Repository
{
    public interface IUnitOfWork:IDisposable
    {
        IUserRepository User { get; }
        int Save();
    }
}
