using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IVisitorStatisticRespository:IRespository<VisitorStatistic>
    {

    }
   public class VisitorStatisticRespository : RespositoryBase<VisitorStatistic>,IVisitorStatisticRespository
    {
        public VisitorStatisticRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
