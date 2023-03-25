using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
  public  interface IColorRespository : IRespository<Color>
    {
    }
    public class ColorRespository:RespositoryBase<Color>,IColorRespository
    {
        public ColorRespository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
