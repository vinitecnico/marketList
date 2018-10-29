using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MarketList.WebApi.Model;

namespace MarketList.WebApi.Repository
{
    public class SupermarketRepository : IRepository<Supermarket>
    {
         private readonly IContext<Supermarket> _context;

        public SupermarketRepository(IContext<Supermarket> context)
        {
            _context = context;
        }

        public async Task Create(Supermarket item)
        {
            await _context.collection.InsertOneAsync(item);
        }

        public async Task<bool> Delete(string id)
        {
            var result = await _context.collection.FindOneAndDeleteAsync(x => x.Id.ToString() == id);
            return true;
        }

        public async Task<IEnumerable<Supermarket>> GetAll()
        {
            return await _context.collection.Find(_ => true).ToListAsync();
        }

        public async Task<Supermarket> GetById(string id)
        {
            return await _context.collection.Find(x => x.Id.ToString() == id).FirstAsync();
        }

        public async Task<bool> Update(Supermarket item)
        {
            var filter2 = Builders<Supermarket>.Filter.Eq("_id", item.Id);
            var update2 = Builders<Supermarket>.Update.Inc(c => c.ProductName, item.ProductName);
            var options2 = new FindOneAndUpdateOptions<Supermarket> { IsUpsert = true, ReturnDocument = ReturnDocument.After};
            var result2 = await _context.collection.FindOneAndUpdateAsync(filter2, update2, options2);
            return true;
        }
    }
}