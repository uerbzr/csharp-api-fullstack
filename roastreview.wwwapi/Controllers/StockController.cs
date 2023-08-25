using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using roastreview.data;
using roastreview.models;

namespace roastreview.wwwapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        [HttpGet(Name = "GetCoffeeStock")]
        public IEnumerable<StockItem> GetCoffees()
        {
            return StockList.Coffees.ToArray();
            
        }
    }
}
