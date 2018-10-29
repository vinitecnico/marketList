using System.Collections.Generic;
using System.Threading.Tasks;
using MarketList.WebApi.Model;
using MongoDB.Bson;
using MongoDB.Driver;

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
            var result = await _context.collection.FindOneAndDeleteAsync(x => x.Id == ObjectId.Parse(id));
            return true;
        }

        public async Task<IEnumerable<Supermarket>> GetAll()
        {
            return await _context.collection.Find(_ => true).ToListAsync();
        }

        public async Task<Supermarket> GetById(string id)
        {
            return await _context.collection.Find(x => x.Id == ObjectId.Parse(id)).FirstOrDefaultAsync();
        }

        public async Task Update(string id, Supermarket item)
        {
            var filter = Builders<Supermarket>.Filter.Eq(s => s.Id, ObjectId.Parse(id));
            var update = Builders<Supermarket>.Update.Set(s => s.ProductName, item.ProductName);
            await _context.collection.UpdateOneAsync(filter, update);
        }
    }
}