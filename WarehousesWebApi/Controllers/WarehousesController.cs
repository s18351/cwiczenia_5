using Microsoft.AspNetCore.Mvc;
using WarehousesWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarehousesWebApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehousesController : ControllerBase
    {
        //private IDatabse _database;
        //public WarehousesController(IDatabse database) 
        //{ 
        //    _database = database;
        //}   


        // GET: api/<WarehousesController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET api/<WarehousesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<WarehousesController>
        [HttpPost]
        public void Post([FromBody] ProductWarehouse productWarehouse)
        {
            Databse databse = new Databse();
            databse.ExecuteStoredProcedure("AddProductToWarehouse", new Dictionary<string, object> {
                { "@IdProduct", productWarehouse.IdProduct},
                { "@IdWarehouse", productWarehouse.IdWarehouse},
                { "@Amount", productWarehouse.Amount},
                { "@CreatedAt", productWarehouse.CreatedAt}


            });
        }

        // PUT api/<WarehousesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<WarehousesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
