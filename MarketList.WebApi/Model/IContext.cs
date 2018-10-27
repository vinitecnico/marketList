using MongoDB.Driver;

namespace MarketList.WebApi.Model
{
    public interface IContext<T> where T : new()
    {
        IMongoCollection<T> collection { get; }
    }
}