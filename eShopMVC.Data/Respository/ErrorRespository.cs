using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface IErrorRespository : IRespository<Error> { }
  public  class ErrorRespository :RespositoryBase<Error>,IErrorRespository
    {
        public ErrorRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
