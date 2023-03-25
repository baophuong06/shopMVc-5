using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface ISlideRespository:IRespository<Slide>
    { }
   public class SlideRespository : RespositoryBase<Slide>,ISlideRespository
    {
        public SlideRespository(IDbFactory dbFactory) : base(dbFactory) { }
    }
}
