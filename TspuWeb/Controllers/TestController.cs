using Microsoft.AspNetCore.Mvc;

namespace TspuWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("{size}")]
        public ActionResult<int[]> Get([FromRoute] int size)
        {
            int[] x = new int[size];

            for (int i = 0; i < size; i++)
            {
                x[i] = Random.Shared.Next(-100, 100);
            }
            return Ok(x);
        }

    }
}
