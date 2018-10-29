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
        public async Task<ActionResult<IEnumerable<Supermarket>>> Get()
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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
