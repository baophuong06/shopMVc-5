using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private DBShopMVCContext dbContext;
      public  void Commit()
        {
            DbContext.SaveChanges();
        }
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public DBShopMVCContext DbContext { get { return dbContext ?? (dbContext = dbFactory.Init()); } }
    }
}
