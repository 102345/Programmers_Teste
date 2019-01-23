using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Programmers.Data.Mappers;

namespace Programmers.Data
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new PriceMap());
                config.ForDommel();
            });
        }
    }
}
