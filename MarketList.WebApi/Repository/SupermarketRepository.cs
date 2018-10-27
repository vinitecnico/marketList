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

        public Task Create(Supermarket item)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Supermarket>> GetAll()
        {
            return await _context.collection.Find(_ => true).ToListAsync();
        }

        public Task<Supermarket> GetById(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> Update(Supermarket item)
        {
            throw new System.NotImplementedException();
        }
    }
}