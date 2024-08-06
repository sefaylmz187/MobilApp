using MobilApp.DataAccess.Context;
using MobilApp.Entities;
using MobilApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilApp.DataAccess.Implementation
{
    public class ProductRepository:GenericRepository<Products>,IProductRepository
    {
        public ProductRepository(MobilAppDbContext carcontext) : base(carcontext)
        {

        }
    }
}
