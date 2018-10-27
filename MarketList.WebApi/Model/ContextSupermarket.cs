using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MarketList.WebApi.Model
{
     public class ContextSupermarket : IContext<Supermarket>
    {
        private readonly IMongoDatabase _db;

        public ContextSupermarket(IOptions<Settings> options)
        {
            var client = new MongoClient(options.Value.ConnectionString);
            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Supermarket> collection => _db.GetCollection<Supermarket>("products");
    }
}