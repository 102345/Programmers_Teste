using Programmers.Domain.Entities;

namespace Programmers.Business.Interface
{
    public interface IPriceBusiness
    {
        Price GetPriceId(int id);

        decimal CalculateTicketPriceTotal(int idEvent, int audience);
    }
}
