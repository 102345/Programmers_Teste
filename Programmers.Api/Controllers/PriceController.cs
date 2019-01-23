using Programmers.Business.Interface;
using Programmers.Business.ViewModels;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Programmers.Api.Controllers
{
    public class PriceController : ControllerBase
    {
        private IPriceBusiness _priceBusiness;

        public PriceController(IPriceBusiness priceBusiness)
        {
            _priceBusiness = priceBusiness;
        }

        
        [HttpPost]
        [Route("api/v1/Price/CalculateTicketTotal/")]
        public HttpResponseMessage CalculateTicketTotal([FromBody]ClientPriceViewModel clientPriceViewModel)
        {


            try
            {

                var price = _priceBusiness.GetPriceId(clientPriceViewModel.idEvent);

                if (price.Id == 0)
                {

                    JsonResult.Status = false;
                    JsonResult.Message = "404 Not Found";
                    return Request.CreateResponse(HttpStatusCode.NotFound, JsonResult);

                }

                decimal value = _priceBusiness.CalculateTicketPriceTotal(clientPriceViewModel.idEvent, clientPriceViewModel.audience);

                var clientRetPriceViewModel = new ClientPriceViewModel();

                clientRetPriceViewModel.nameCustomer = clientPriceViewModel.nameCustomer;
                clientRetPriceViewModel.audience = clientPriceViewModel.audience;
                clientRetPriceViewModel.idEvent = clientPriceViewModel.idEvent;
                clientRetPriceViewModel.value = value;



                JsonResult.Status = true;
                JsonResult.Object = clientRetPriceViewModel;
                return Request.CreateResponse(HttpStatusCode.OK, JsonResult);
            }
            catch (Exception ex)
            {
                JsonResult.Status = false;
                JsonResult.Message = ex.Message;
                return Request.CreateResponse(HttpStatusCode.BadRequest, JsonResult);
            }
        }

      
    }
}
