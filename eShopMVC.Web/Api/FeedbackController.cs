using eShopMVC.Model.Models;
using eShopMVC.Service;
using eShopMVC.Web.Infracstructure.Core;
using eShopMVC.Web.Infracstructure.Extensions;
using eShopMVC.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace eShopMVC.Web.Api
{
    public class FeedbackController : ApiControllerBase
    {
        IFeedbackService _iFeedbackService;
        public FeedbackController(IErrorService _errorService, IFeedbackService feedbackService) : base(_errorService)
        {
            _iFeedbackService = feedbackService;
        }
        [HttpPost]
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, FeedbackViewModel feedbackViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    Feedback fb = new Feedback();
                    fb.UpdateFeedback(feedbackViewModel);
                    var feedbackAdd = _iFeedbackService.Create(fb);
                    _iFeedbackService.Save();
                    response = request.CreateResponse(HttpStatusCode.Created, feedbackAdd);
                }
                return response;
            });
        }
    }
}
