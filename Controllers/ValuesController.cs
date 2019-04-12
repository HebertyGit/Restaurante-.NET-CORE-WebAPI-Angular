using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestauranteWeb.API.Data;
using RestauranteWeb.API.Model;

namespace RestauranteWeb.API.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _conext;

        public ValuesController(DataContext conext)
        {
            _conext = conext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _conext.Prato.ToListAsync();
                return Ok(results);    
            }
            catch (System.Exception)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "A conexão com o banco de dados falhou");

            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task <IActionResult> Get(int id)
        {

            try
            {
                var results = await _conext.Prato.FirstOrDefaultAsync(x => x.PratoId == id);
                return Ok(results);    
            }
            catch (System.Exception)
            {                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "A conexão com o banco de dados falhou");

            }
             
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
