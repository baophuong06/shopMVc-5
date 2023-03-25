using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Infrastructure
{
    public class DbFactory : IDisposable, IDbFactory
    {
        private DBShopMVCContext dbContext;
        public void Dispose()
        {
            if(dbContext!=null)
            {
                dbContext.Dispose();
            }
        }

        public DBShopMVCContext Init()
        {
            return dbContext ?? (dbContext = new DBShopMVCContext());
        }
    }
}
