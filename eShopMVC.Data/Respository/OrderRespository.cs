using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IOrderRespository:IRespository<Order>
    { }
    public class OrderRespository : RespositoryBase<Order>, IOrderRespository
    {
        public OrderRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
