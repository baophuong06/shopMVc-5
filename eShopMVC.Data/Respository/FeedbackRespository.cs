﻿using eShopMVC.Data.Infrastructure;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Data.Respository
{
   public interface IFeedbackRespository : IRespository<Feedback>
    {

    }
    public class FeedbackRespository : RespositoryBase<Feedback>, IFeedbackRespository
    {
        public FeedbackRespository(DbFactory dbFactory) : base(dbFactory) { }
    }

}
