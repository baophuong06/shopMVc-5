﻿using eShopMVC.Data.Infrastructure;
using eShopMVC.Data.Respository;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Service
{
    public interface IFunctionService
    {
        Function Create(Function function);

        IEnumerable<Function> GetAll(string filter);

        IEnumerable<Function> GetAllWithPermission(string userId);

        IEnumerable<Function> GetAllWithParentID(string parentId);

        Function Get(string id);

        void Update(Function function);

        void Delete(string id);

        void Save();
        bool CheckExistedId(string id);
    }
    public  class FunctionService : IFunctionService
    {
        private readonly IFunctionRespository _functionRespository;
        private readonly IUnitOfWork _unitOfWork;
        public FunctionService(IFunctionRespository functionRespository,UnitOfWork unitOfWork)
        {
            _functionRespository = functionRespository;
            _unitOfWork = unitOfWork;
        }

        public bool CheckExistedId(string id)
        {
          return  _functionRespository.CheckContain(x => x.ID == id);
        }

        public Function Create(Function function)
        {
            return _functionRespository.Add(function);
        }

        public void Delete(string id)
        {
            var function = _functionRespository.GetSingleByCondition(x => x.ID == id);
            _functionRespository.Delete(function);
        }

        public Function Get(string id)
        {
            return _functionRespository.GetSingleByCondition(x => x.ID == id);
        }

        public IEnumerable<Function> GetAll(string filter)
        {
            var query = _functionRespository.GetMulti(x => x.Status);
            if(!string.IsNullOrEmpty(filter))
            
                query = query.Where(x => x.Name.Contains(filter));

           
            return query.OrderBy(x=>x.ParentId);
        }

        public IEnumerable<Function> GetAllWithParentID(string parentId)
        {
            return _functionRespository.GetMulti(x => x.ParentId == parentId);
        }

        public IEnumerable<Function> GetAllWithPermission(string userId)
        {
            var query = _functionRespository.GetListFunctionWithPermission(userId);
            return query.OrderBy(x => x.ParentId);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Function function)
        {
            _functionRespository.Update(function);
        }
    }
}
