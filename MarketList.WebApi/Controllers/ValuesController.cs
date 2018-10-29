using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarketList.WebApi.Model;
using MarketList.WebApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MarketList.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRepository<Model.Supermarket> _supermarketRepository;

        public ValuesController(IRepository<Model.Supermarket> supermarketRepository)
        {
            _supermarketRepository = supermarketRepository;
        }

        // GET api/values
        [HttpGet]
        public async Task<IEnumerable<Supermarket>> Get()
        {
            var result = await _supermarketRepository.GetAll();
            return result.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Supermarket>> Get(string id)
        {
            var result = await _supermarketRepository.GetById(id);
            return result;
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] Supermarket item)
        {
            await _supermarketRepository.Create(item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] Supermarket item)
        {
            await _supermarketRepository.Update(id, item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(string id)
        {
            return await _supermarketRepository.Delete(id);
        }
    }
}
