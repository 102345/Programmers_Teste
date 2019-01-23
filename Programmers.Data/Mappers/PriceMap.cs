using Dapper.FluentMap.Dommel.Mapping;
using Programmers.Domain.Entities;

namespace Programmers.Data.Mappers
{
    public class PriceMap : DommelEntityMap<Price>
    {
        public PriceMap()
        {
            ToTable("Price");
            Map(x => x.Id).ToColumn("id").IsKey();
            Map(x => x.idEvent).ToColumn("idEvent");
            Map(x => x.audience).ToColumn("audience");
            Map(x => x.value).ToColumn("value");

        }
    }
}
