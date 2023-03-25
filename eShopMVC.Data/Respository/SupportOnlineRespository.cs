using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface ISupportOnlineRespository:IRespository<SupportOnline>
    {

    }
  public  class SupportOnlineRespository : RespositoryBase<SupportOnline>,ISupportOnlineRespository
    
    {
        public SupportOnlineRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
