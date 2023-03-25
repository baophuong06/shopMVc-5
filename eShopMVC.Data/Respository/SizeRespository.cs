﻿using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
   public interface ISizeRespository : IRespository<Size>
    {

    }
    public class SizeRespository:RespositoryBase<Size>,ISizeRespository
    {
        public SizeRespository(DbFactory dbFactory) : base(dbFactory) { }
    }
}
