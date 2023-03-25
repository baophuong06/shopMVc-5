using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IOrderDetailRespository : IRespository<OrderDetail>{ }
   public class OrderDetailRespository : RespositoryBase<OrderDetail>,IOrderDetailRespository
    {
        public OrderDetailRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
