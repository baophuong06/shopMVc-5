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
    public interface IFeedbackService
    {
        void Save();
        Feedback Create(Feedback feedback);
    }
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRespository _feedbackRespository;
        private readonly IUnitOfWork _unitOfWork;
        public FeedbackService(IFeedbackRespository feedbackRespository,IUnitOfWork unitOfWork)
        {
            _feedbackRespository = feedbackRespository;
            _unitOfWork = unitOfWork;
        }
        public Feedback Create(Feedback feedback)
        {

            return _feedbackRespository.Add(feedback);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }
    }
}
