using eShopMVC.Data.Infrastructure;
using eShopMVC.Data.Respository;
using eShopMVC.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopMVC.Service
{
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }
    public class ErrorService : IErrorService
    {
        IErrorRespository _errorRespository;
        IUnitOfWork _unitOfWork;
        public ErrorService(IErrorRespository errorRespository,IUnitOfWork unitOfWork)
        {
            this._errorRespository = errorRespository;
            this._unitOfWork = unitOfWork;
        }
        public Error Create(Error error)
        {
            return _errorRespository.Add(error);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
