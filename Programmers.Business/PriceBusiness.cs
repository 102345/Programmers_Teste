using Programmers.Business.Interface;
using Programmers.Data.Repositories;
using Programmers.Domain.Entities;
using System.Linq;

namespace Programmers.Business
{
    public class PriceBusiness : IPriceBusiness
    {
        private readonly PriceRepository _priceRepository;

        public PriceBusiness()
        {
            _priceRepository = new PriceRepository();
        }

        public decimal CalculateTicketPriceTotal(int idEvent,int audience)
        {
            decimal valueCalculate = 0;

            switch (idEvent)
            {
                case (int)Constants.EventType.Tragedy:
                    valueCalculate = CalculateTragedy(idEvent, audience);
                    break;
                case (int)Constants.EventType.Comedy:
                    valueCalculate = CalculateComedy(idEvent, audience);
                    break;
                default:
                    break;
            }

            return valueCalculate;
        }


        private decimal CalculateTragedy(int idEvent,int audience)
        {
            var valueaddicional = 0;

            var priceRet =  _priceRepository.GetList(x => x.idEvent == (int)Constants.EventType.Tragedy)?.Single();

            if (priceRet.audience < audience) valueaddicional = (audience - priceRet.audience) * 1000; 


            return priceRet.value + valueaddicional;

        }


        private decimal CalculateComedy(int idEvent, int audience)
        {
            var valueaddicional = 0;

            var priceRet = _priceRepository.GetList(x => x.idEvent == (int)Constants.EventType.Comedy)?.Single();

            if (priceRet.audience < audience) valueaddicional = (audience - priceRet.audience) * 500;


            return priceRet.value + valueaddicional;

        }

        public Price GetPriceId(int idEvent)
        {
            var price = new Price();

            var priceRet = _priceRepository.GetList(x => x.idEvent == idEvent);

            if (priceRet.Count() > 0) price = priceRet.Single();

            return price;
        }   
    }
}
