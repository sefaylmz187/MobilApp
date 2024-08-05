using MobilApp.DataAccess.Context;
using MobilApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilApp.DataAccess.Implementation
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MobilAppDbContext _carcontext;
        public UnitOfWork(MobilAppDbContext carcontext)
        {
            _carcontext = carcontext;
            User = new UserRepository(_carcontext);
        }

        public IUserRepository User { get;private set; }
        public int Save()
        {
            return _carcontext.SaveChanges();
        }
        public void Dispose()
        {
            _carcontext.Dispose();
        }
    }
}
