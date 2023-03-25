﻿using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
    public interface ITagRespository:IRespository<Tag>
    {

    }
  public  class TagRespository : RespositoryBase<Tag>,ITagRespository
    {
        public TagRespository(IDbFactory dbFactory) : base(dbFactory) { }

    }
}
